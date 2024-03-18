using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Commands.Requests.Order
{
    public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public Guid OrderId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid ProductId { get; set; }
        public Guid AddressId { get; set; }
    }
}
