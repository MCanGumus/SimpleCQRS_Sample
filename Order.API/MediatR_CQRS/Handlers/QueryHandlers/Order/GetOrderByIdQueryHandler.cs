using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Queries.Requests.Order;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;
using Order.API.MediatR_CQRS.Queries.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Order
{
    public class GetOrderByIdQueryHandler(OrderAPIDbContext context) : IRequestHandler<GetOrderByIdQueryRequest, GetOrderByIdQueryResponse>
    {
        public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQueryRequest request, CancellationToken cancellationToken)
        {
            OrderEntity orderEntity = await context.Orders.FirstOrDefaultAsync(x => x.OrderId == request.OrderId);

            return new GetOrderByIdQueryResponse()
            {
                AddressId = orderEntity.AddressId,
                Count = orderEntity.Count,
                OrderId = orderEntity.OrderId,
                CustomerId = orderEntity.CustomerId,
                TotalPrice = orderEntity.TotalPrice,
                Status = orderEntity.Status,
                ProductId = orderEntity.ProductId,
            };
        }
    }
}
