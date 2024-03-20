using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Commands.Requests.Order
{
    public class ChangeOrderStatusCommandRequest : IRequest<ChangeOrderStatusCommandResponse>
    {
        public Guid OrderId{ get; set; }
        public string Status{ get; set; }
    }
}
