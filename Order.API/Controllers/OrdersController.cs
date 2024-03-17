using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Context;
using Order.API.ViewModels;

namespace Order.API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(OrderAPIDbContext context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderVM createOrder)
        {
            Order.API.Entities.OrderEntity order = new()
            {
                OrderId = Guid.NewGuid(),
                AddressId = createOrder.AddressId,
                Count = createOrder.Count,
                CustomerId = createOrder.CustomerId,
                ProductId = createOrder.ProductId,
                TotalPrice = createOrder.Count * createOrder.Price,
                CreatedDate = DateTime.Now,
                Status = "Waiting",
            };

            context.Orders.Add(order);
            
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
