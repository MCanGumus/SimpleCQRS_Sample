using Microsoft.EntityFrameworkCore;
using Stock.API.Context;
using Stock.API.CQRS.Commands.Requests.Product;
using Stock.API.CQRS.Commands.Responses.Product;
using Stock.API.Entities;

namespace Stock.API.CQRS.Handlers.CommandHandlers.Product
{
    public class UpdateProductCommandHandler(StockAPIDbContext context)
    {
        public async Task<UpdateProductCommandResponse> UpdateProduct
            (UpdateProductCommandRequest request)
        {
            Stock.API.Entities.Product product = await context.Products.FirstOrDefaultAsync(x => x.ProductId == request.ProductId);

            if (product == null) 
            {
                return new UpdateProductCommandResponse()
                {
                    IsSuccess = false
                };
            }

            product.Quantity = request.Quantity;
            product.Name = request.Name;
            product.ImageUrl = request.ImageUrl;

            context.Products.Update(product);
            await context.SaveChangesAsync();

            return new UpdateProductCommandResponse()
            {
                IsSuccess = true
            };
        }
    }
}
