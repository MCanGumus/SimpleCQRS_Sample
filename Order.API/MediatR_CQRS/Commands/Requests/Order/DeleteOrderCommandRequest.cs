using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Commands.Requests.Order
{
    public class DeleteOrderCommandRequest : IRequest<DeleteOrderCommandResponse>
    {
        public Guid OrderId { get; set; }
    }
}
