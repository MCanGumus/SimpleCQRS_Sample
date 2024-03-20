using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Context;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Queries.Requests.Customer;
using Order.API.MediatR_CQRS.Queries.Requests.Order;
using Order.API.ViewModels;

namespace Order.API.Controllers 
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOrderCommandRequest request)
             => Ok(await mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateOrderCommandRequest request)
            => Ok(await mediator.Send(request));

        [HttpDelete("{OrderId}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOrderCommandRequest request)
            => Ok(await mediator.Send(request));

        [HttpGet("{OrderId}")]
        public async Task<IActionResult> Get([FromRoute] GetOrderByIdQueryRequest request)
                  => Ok(await mediator.Send(request));

        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] GetAllOrderQueryRequest request)
                  => Ok(await mediator.Send(request));

        [HttpPut]
        public async Task<IActionResult> ChangeStatus([FromBody] ChangeOrderStatusCommandRequest request)
            => Ok(await mediator.Send(request));

    }
}
