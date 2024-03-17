using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;
using System.Diagnostics;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class DeleteOrderCommandHandler(OrderAPIDbContext context) : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
    {
        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            OrderEntity orderEntity = await context.Orders.FirstOrDefaultAsync(x => x.OrderId == request.OrderId);

            if (orderEntity == null) { return new DeleteOrderCommandResponse() { IsSuccess = false}; }

            context.Orders.Remove(orderEntity);
            await context.SaveChangesAsync();

            return new DeleteOrderCommandResponse() { IsSuccess = true };
        }
    }
}
