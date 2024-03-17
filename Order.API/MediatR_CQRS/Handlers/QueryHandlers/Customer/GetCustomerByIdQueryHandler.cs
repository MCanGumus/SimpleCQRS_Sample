using MediatR;
using Order.API.MediatR_CQRS.Queries.Requests.Customer;
using Order.API.MediatR_CQRS.Queries.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Customer
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQueryRequest, GetCustomerByIdQueryResponse>
    {
        public Task<GetCustomerByIdQueryResponse> Handle(GetCustomerByIdQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
