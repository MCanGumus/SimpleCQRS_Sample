using Microsoft.EntityFrameworkCore;
using Stock.API.Context;
using Stock.API.CQRS.Commands.Requests.Product;
using Stock.API.CQRS.Commands.Responses.Product;

namespace Stock.API.CQRS.Handlers.CommandHandlers.Product
{
    public class DeleteProductCommandHandler(StockAPIDbContext context)
    {
        public async Task<DeleteProductCommandResponse> DeleteProduct(DeleteProductCommandRequest request)
        {
            Stock.API.Entities.Product product = await context.Products.FirstOrDefaultAsync(x => x.ProductId == request.ProductId);

            if (product == null)
                return new DeleteProductCommandResponse { IsSuccess = false };


            context.Products.Remove(product);
            await context.SaveChangesAsync();

            return new DeleteProductCommandResponse { IsSuccess = true };
        }
    }
}
