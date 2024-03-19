using MassTransit;
using Microsoft.EntityFrameworkCore;
using Order.API.Consumer;
using Order.API.Context;
using Shared.Settings;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Mediatr CQRS
builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(OrderAPIDbContext).Assembly));

#endregion

builder.Services.AddDbContext<OrderAPIDbContext>(options =>
{
    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionConnection"), builder => builder.MigrationsAssembly("Order.API"));
    }
    else // In Development Environment
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionConnection"), builder => builder.MigrationsAssembly("Order.API"));
    }
});

builder.Services.AddMassTransit(configurator =>
{
    configurator.AddConsumer<StockUpdatedEventConsumer>();
    configurator.UsingRabbitMq((context, _configurator) =>
    {
        _configurator.Host(builder.Configuration["RabbitMQ"]);
        _configurator.ReceiveEndpoint(RabbitMQSettings.Order_StockUpdatedEventQueue, e => e.ConfigureConsumer<StockUpdatedEventConsumer>(context));
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
