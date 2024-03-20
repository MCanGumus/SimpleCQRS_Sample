using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Queries.Requests.Address;
using Order.API.MediatR_CQRS.Queries.Requests.Customer;
using Order.API.ViewModels;

namespace Order.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomerCommandRequest request)
              => Ok(await mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCustomerCommandRequest request)
            => Ok(await mediator.Send(request));

        [HttpDelete("{CustomerId}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCustomerCommandRequest request)
            => Ok(await mediator.Send(request));

        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> Get([FromRoute] GetCustomerByIdQueryRequest request)
                  => Ok(await mediator.Send(request));

        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] GetAllCustomerQueryRequest request)
                  => Ok(await mediator.Send(request));

        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> Validate([FromRoute] ValidateCustomerQueryRequest request)
                  => Ok(await mediator.Send(request));
    }
}
