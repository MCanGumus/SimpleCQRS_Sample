using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class UpdateOrderCommandHandler(OrderAPIDbContext context) : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            OrderEntity orderEntity = await context.Orders.FirstOrDefaultAsync(x => x.OrderId == request.OrderId);

            if (orderEntity == null) { return new UpdateOrderCommandResponse() { IsSuccess = false }; }

            orderEntity.Status = request.Status;
            orderEntity.AddressId = request.AddressId;
            orderEntity.ProductId = request.ProductId;
            orderEntity.TotalPrice = request.TotalPrice;
            orderEntity.Count = request.Count;
            orderEntity.UpdatedDate = DateTime.Now;

            context.Orders.Update(orderEntity);

            await context.SaveChangesAsync();

            return new UpdateOrderCommandResponse() { IsSuccess = true };
        }
    }
}
