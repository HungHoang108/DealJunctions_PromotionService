using DealJunction.Services.PromotionAPI.Models;
using DealJunction.Services.PromotionAPI.Service;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace DealJunction.Services.PromotionAPI.Messaging
{
    public class RabbitMQConsumer : BackgroundService
    {
        private readonly string _hostName;
        private readonly string _userName;
        private readonly string _password;

        private IConnection _connection;
        private IModel _channel;
        private EmployeeService _employeeService;


        public RabbitMQConsumer(EmployeeService employeeService)
        {
            _hostName = "localhost";
            _userName = "guest";
            _password = "guest";
            _employeeService = employeeService;

            var factory = new ConnectionFactory
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare("current-employee1", durable: true, exclusive: false, autoDelete: false, arguments: null);
            _employeeService = employeeService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (ch, ea) =>
            {
                var content = Encoding.UTF8.GetString(ea.Body.ToArray());
                var email = JsonConvert.DeserializeObject<string>(content);

                // Handle the message asynchronously
                HandleMessage(email).GetAwaiter().GetResult();
                _channel.BasicAck(ea.DeliveryTag, false);
            };
            _channel.BasicConsume("current-employee1", false, consumer);
            return Task.CompletedTask;
        }
        private async Task HandleMessage(string email)
        {
            var emEmail = new EmployeeEmails { Email = email };
            _employeeService.CreateEmployee(emEmail).GetAwaiter().GetResult();
        }
    }
}