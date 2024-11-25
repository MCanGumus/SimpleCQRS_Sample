using Microsoft.EntityFrameworkCore;
using Stock.API.Context;
using Stock.API.CQRS.Queries.Requests.Product;
using Stock.API.CQRS.Queries.Responses.Product;

namespace Stock.API.CQRS.Handlers.QueryHandlers.Product
{
    public class GetProductByIdQueryHandler(StockAPIDbContext context)
    {
        public async Task<GetProductByIdQueryResponse> Get
            (GetProductByIdQueryRequest request)
        {
            Stock.API.Entities.Product product = 
                await context.Products.FirstOrDefaultAsync(x => x.ProductId == request.ProductId);


            if (product == null)
            {
                return null;
            }

            return new GetProductByIdQueryResponse
            {
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Quantity = product.Quantity,
            };
        }
    }
}
