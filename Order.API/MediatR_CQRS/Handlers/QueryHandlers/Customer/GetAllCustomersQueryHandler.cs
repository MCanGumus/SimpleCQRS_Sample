using MediatR;
using Order.API.MediatR_CQRS.Queries.Requests.Customer;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Customer
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomerQueryRequest, GetAllCustomersQueryResponse>
    {
        public Task<GetAllCustomersQueryResponse> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
