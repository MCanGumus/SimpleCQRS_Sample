using MassTransit;
using MassTransit.Internals;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Shared.Events;
using Stock.API.Context;
using Stock.API.CQRS.Handlers.CommandHandlers.Product;
using Stock.API.CQRS.Handlers.QueryHandlers.Product;

namespace Stock.API.Consumers
{
    public class OrderCreatedEventConsumer(IPublishEndpoint _publisher, StockAPIDbContext ctx) : IConsumer<OrderCreatedEvent>
    {
        public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
        {
            var product = await ctx.Products.FirstOrDefaultAsync(x => x.ProductId == context.Message.ProductId);

            if (product == null) 
            {
                return;
            }

            if (product.Quantity < context.Message.Count)
            {
                return;
            }
            product.Quantity -= context.Message.Count;

            ctx.Products.Update(product);

            await ctx.SaveChangesAsync();

            StockUpdatedEvent stockUpdatedEvent = new() 
            {
                OrderId = context.Message.OrderId,
            };

            await _publisher.Publish(stockUpdatedEvent);
        }
    }
}
