using MediatR;
using Order.API.MediatR_CQRS.Queries.Requests.Address;
using Order.API.MediatR_CQRS.Queries.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Address
{
    public class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQueryRequest, GetAddressByIdQueryResponse>
    {
        public Task<GetAddressByIdQueryResponse> Handle(GetAddressByIdQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
