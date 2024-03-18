using MassTransit;
using MediatR;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;
using Shared.Events;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class CreateOrderCommandHandler(OrderAPIDbContext context, IPublishEndpoint _publisher) : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            OrderEntity orderEntity = new()
            {
                OrderId = Guid.NewGuid(),
                AddressId = request.AddressId,
                Count = request.Count,
                CustomerId = request.CustomerId,
                Status = "Pending...",
                ProductId = request.ProductId,
                TotalPrice = request.TotalPrice,
                CreatedDate = DateTime.Now,
            };

            context.Orders.Add(orderEntity);
            await context.SaveChangesAsync();

            OrderCreatedEvent orderCreatedEvent = new() 
            {
                Count = request.Count,
                OrderId = orderEntity.OrderId,
                ProductId = orderEntity.ProductId
            };

            await _publisher.Publish(orderCreatedEvent);

            return new CreateOrderCommandResponse() { OrderId = orderEntity.OrderId};
        }
    }
}
