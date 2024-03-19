using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Shared.Events;

namespace Order.API.Consumer
{
    public class StockUpdatedEventConsumer(OrderAPIDbContext ctx) : IConsumer<StockUpdatedEvent>
    {
        public async Task Consume(ConsumeContext<StockUpdatedEvent> context)
        {
            var order = await ctx.Orders.FirstOrDefaultAsync(x => x.OrderId == context.Message.OrderId);
            
            if (order == null) { return; }

            order.Status = "Successfull";

            ctx.Orders.Update(order);

            await ctx.SaveChangesAsync();
        }
    }
}
