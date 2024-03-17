using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Queries.Requests.Customer;
using Order.API.MediatR_CQRS.Queries.Responses.Address;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Customer
{
    public class GetCustomerByIdQueryHandler(OrderAPIDbContext context) : IRequestHandler<GetCustomerByIdQueryRequest, GetCustomerByIdQueryResponse>
    {
        public async Task<GetCustomerByIdQueryResponse> Handle(GetCustomerByIdQueryRequest request, CancellationToken cancellationToken)
        {
            CustomerEntity customerEntity = await context.Customers.FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId);

            return new GetCustomerByIdQueryResponse()
            {
                AddressId = customerEntity.AddressId,
                Email= customerEntity.Email,
                Name = customerEntity.Name,
                CustomerId = customerEntity.CustomerId,
            };
        }
    }
}
