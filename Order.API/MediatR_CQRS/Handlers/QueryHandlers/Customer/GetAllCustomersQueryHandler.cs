using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.MediatR_CQRS.Queries.Requests.Customer;
using Order.API.MediatR_CQRS.Queries.Responses.Address;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Customer
{
    public class GetAllCustomersQueryHandler(OrderAPIDbContext context) : IRequestHandler<GetAllCustomerQueryRequest, List<GetAllCustomersQueryResponse>>
    {
        public async Task<List<GetAllCustomersQueryResponse>> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            return await context.Customers.Select(x => new GetAllCustomersQueryResponse
            {
                Name = x.Name,
                Email = x.Email,
                AddressId = x.AddressId,
                CustomerId = x.CustomerId,
            }).ToListAsync();
        }
    }
}
