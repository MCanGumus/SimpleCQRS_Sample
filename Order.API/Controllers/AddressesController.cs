using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Context;
using Order.API.Entities;
using Order.API.ViewModels;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController(OrderAPIDbContext context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressVM createAddress)
        {
            Address address = new()
            {
                AddressId = Guid.NewGuid(),
                City = createAddress.City,
                CityCode = createAddress.CityCode,
                Country = createAddress.Country,
                AddressLine = createAddress.AddressLine,
            };

            context.Addresses.Add(address);

            await context.SaveChangesAsync();

            return Ok(address.AddressId);
        }

    }
}
