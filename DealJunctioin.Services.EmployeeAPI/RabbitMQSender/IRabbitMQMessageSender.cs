namespace DealJunction.Services.EmployeeAPI.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(Object message, string queueName);
    }
}
