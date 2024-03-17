using MediatR;
using Order.API.MediatR_CQRS.Queries.Requests.Order;
using Order.API.MediatR_CQRS.Queries.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Order
{
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrderQueryRequest, GetAllOrdersQueryResponse>
    {
        public Task<GetAllOrdersQueryResponse> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
