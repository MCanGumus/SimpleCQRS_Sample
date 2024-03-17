using MediatR;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class CreateOrderCommandHandler(OrderAPIDbContext context) : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            OrderEntity orderEntity = new()
            {
                OrderId = Guid.NewGuid(),
                AddressId = request.AddressId,
                Count = request.Count,
                CustomerId = request.CustomerId,
                Status = request.Status,
                ProductId = request.ProductId,
                TotalPrice = request.TotalPrice,
                CreatedDate = DateTime.Now,
            };

            context.Orders.Add(orderEntity);
            await context.SaveChangesAsync();

            return new CreateOrderCommandResponse() { OrderId = orderEntity.OrderId};
        }
    }
}
