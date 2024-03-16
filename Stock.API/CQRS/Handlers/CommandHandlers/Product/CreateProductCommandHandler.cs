using Stock.API.Context;
using Stock.API.CQRS.Commands.Requests.Product;
using Stock.API.CQRS.Commands.Responses.Product;
using Stock.API.Entities;

namespace Stock.API.CQRS.Handlers.CommandHandlers.Product
{
    public class CreateProductCommandHandler(StockAPIDbContext context)
    {
        public async Task<CreateProductCommandResponse> CreateProduct
            (CreateProductCommandRequest request)
        {
            Stock.API.Entities.Product product = new()
            {
                ProductId = Guid.NewGuid(),
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Quantity = request.Quantity,
            };

            context.Products.Add(product);

            await context.SaveChangesAsync();

            return new CreateProductCommandResponse() 
            {
                ProductId = product.ProductId
            };
        }
    }
}
