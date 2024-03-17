using Microsoft.EntityFrameworkCore;
using Stock.API.Context;
using Stock.API.CQRS.Handlers.CommandHandlers.Product;
using Stock.API.CQRS.Handlers.QueryHandlers.Product;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Manual CQRS 
builder.Services.AddScoped<CreateProductCommandHandler>()
                .AddScoped<DeleteProductCommandHandler>()
                .AddScoped<UpdateProductCommandHandler>()
                .AddScoped<GetAllProductsQueryHandler>()
                .AddScoped<GetProductByIdQueryHandler>();
#endregion

builder.Services.AddDbContext<StockAPIDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), builder => builder.MigrationsAssembly("Stock.API"));
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
