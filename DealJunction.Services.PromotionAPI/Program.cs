using DealJunction.Services.PromotionAPI;
using DealJunction.Services.PromotionAPI.Messaging;
using DealJunction.Services.PromotionAPI.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(MappingConfig).Assembly);

var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddSingleton(new EmployeeService(optionBuilder.Options));
builder.Services.AddHostedService<RabbitMQConsumer>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
ApplyMigration();

app.Run();

void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        var _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        if (_db.Database.GetPendingMigrations().Count() > 0)
        {
            _db.Database.Migrate();
        }
    }
}