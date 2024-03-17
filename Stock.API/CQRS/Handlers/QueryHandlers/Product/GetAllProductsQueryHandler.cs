using Microsoft.EntityFrameworkCore;
using Stock.API.Context;
using Stock.API.CQRS.Queries.Requests.Product;
using Stock.API.CQRS.Queries.Responses.Product;

namespace Stock.API.CQRS.Handlers.QueryHandlers.Product
{
    public class GetAllProductsQueryHandler(StockAPIDbContext context)
    {
        public async Task<List<GetAllProductQueryResponse>> GetAll
            (GetAllProductsQueryRequest request)
        {
            List<Stock.API.Entities.Product> products = 
                await context.Products.ToListAsync();

            return products.Select(prod => new GetAllProductQueryResponse
            {
                ProductId = prod.ProductId,
                ImageUrl = prod.ImageUrl,
                Name = prod.Name,
                Quantity = prod.Quantity,
            }).ToList();
        }
    }
}
