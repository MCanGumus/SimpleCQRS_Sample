using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Queries.Requests.Customer;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Customer
{
    public class ValidateCustomerQueryHandler(OrderAPIDbContext context) : IRequestHandler<ValidateCustomerQueryRequest, ValidateCustomerQueryResponse>
    {
        public async Task<ValidateCustomerQueryResponse> Handle(ValidateCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            CustomerEntity customer = await context.Customers.FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId);

            if (customer == null) 
                return new ValidateCustomerQueryResponse { IsThere = false };

            return new ValidateCustomerQueryResponse { IsThere = true };
        }
    }
}
