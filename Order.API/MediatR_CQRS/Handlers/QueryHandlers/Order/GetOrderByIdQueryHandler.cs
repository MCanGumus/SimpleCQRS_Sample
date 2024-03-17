using MediatR;
using Order.API.MediatR_CQRS.Queries.Requests.Order;
using Order.API.MediatR_CQRS.Queries.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Order
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQueryRequest, GetOrderByIdQueryResponse>
    {
        public Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
