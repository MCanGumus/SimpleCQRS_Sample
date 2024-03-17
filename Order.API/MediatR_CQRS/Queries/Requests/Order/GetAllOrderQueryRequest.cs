using MediatR;
using Order.API.MediatR_CQRS.Queries.Responses.Order;

namespace Order.API.MediatR_CQRS.Queries.Requests.Order
{
    public class GetAllOrderQueryRequest : IRequest<List<GetAllOrdersQueryResponse>>
    {
    }
}
