using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.MediatR_CQRS.Queries.Requests.Order;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;
using Order.API.MediatR_CQRS.Queries.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Order
{
    public class GetAllOrdersQueryHandler(OrderAPIDbContext context) : IRequestHandler<GetAllOrderQueryRequest, List<GetAllOrdersQueryResponse>>
    {
        public async Task<List<GetAllOrdersQueryResponse>> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            return await context.Orders.Select(x => new GetAllOrdersQueryResponse
            {
                AddressId = x.AddressId,
                CustomerId = x.CustomerId,
                Count = x.Count,
                OrderId = x.OrderId,
                ProductId = x.ProductId,
                Status = x.Status,
                TotalPrice = x.TotalPrice,
            }).ToListAsync();
        }
    }
}
