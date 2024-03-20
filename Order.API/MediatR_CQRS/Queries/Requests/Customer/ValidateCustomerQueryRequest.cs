using MediatR;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;

namespace Order.API.MediatR_CQRS.Queries.Requests.Customer
{
    public class ValidateCustomerQueryRequest : IRequest<ValidateCustomerQueryResponse> 
    {
        public Guid CustomerId{ get; set; }
    }
}
