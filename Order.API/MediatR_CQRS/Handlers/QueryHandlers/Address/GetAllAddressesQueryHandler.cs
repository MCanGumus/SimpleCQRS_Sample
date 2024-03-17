using MediatR;
using Order.API.MediatR_CQRS.Queries.Requests.Address;
using Order.API.MediatR_CQRS.Queries.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Address
{
    public class GetAllAddressesQueryHandler : IRequestHandler<GetAllAdressesQueryRequest, GetAllAddressesQueryResponse>
    {
        public Task<GetAllAddressesQueryResponse> Handle(GetAllAdressesQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
