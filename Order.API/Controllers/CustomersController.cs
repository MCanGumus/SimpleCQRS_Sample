using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Context;
using Order.API.Entities;
using Order.API.ViewModels;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController(OrderAPIDbContext context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerVM createCustomer)
        {
            CustomerEntity customer = new()
            {
                CustomerId = Guid.NewGuid(),
                AddressId = createCustomer.AddressId,
                Email = createCustomer.Email,
                Name = createCustomer.Name,
                CreatedAt = DateTime.UtcNow,
            };

            context.Customers.Add(customer);
            await context.SaveChangesAsync();

            return Ok(customer.CustomerId);
        }
    }
}
