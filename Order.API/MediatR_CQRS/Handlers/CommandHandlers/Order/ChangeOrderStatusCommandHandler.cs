using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class ChangeOrderStatusCommandHandler(OrderAPIDbContext context) : IRequestHandler<ChangeOrderStatusCommandRequest, ChangeOrderStatusCommandResponse>
    {
        public async Task<ChangeOrderStatusCommandResponse> Handle(ChangeOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {
            OrderEntity order = await context.Orders.FirstOrDefaultAsync(x => x.OrderId == request.OrderId);

            if (order == null) { return new ChangeOrderStatusCommandResponse { IsSuccess = false }; }

            order.Status = request.Status;

            context.Orders.Update(order);
            await context.SaveChangesAsync();

            return new ChangeOrderStatusCommandResponse { IsSuccess = true };
        }
    }
}
