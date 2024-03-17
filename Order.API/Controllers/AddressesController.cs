using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Queries.Requests.Address;
using Order.API.ViewModels;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAddressCommandRequest request) 
            => Ok(await mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateAddressCommandRequest request)
            => Ok(await mediator.Send(request));

        [HttpDelete("{AddressId}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteAddressCommandRequest request)
            => Ok(await mediator.Send(request));

        [HttpGet("{AddressId}")]
        public async Task<IActionResult> Get([FromRoute] GetAddressByIdQueryRequest request)
                  => Ok(await mediator.Send(request));

        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] GetAllAdressesQueryRequest request)
                  => Ok(await mediator.Send(request));

    }
}
