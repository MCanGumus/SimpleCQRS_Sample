using Microsoft.EntityFrameworkCore;
using Order.API.Context;

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
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), builder => builder.MigrationsAssembly("Order.API"));
});

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

app.Run();
