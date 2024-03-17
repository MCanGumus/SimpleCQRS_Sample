using MediatR;
using Order.API.MediatR_CQRS.Queries.Responses.Address;

namespace Order.API.MediatR_CQRS.Queries.Requests.Address
{
    public class GetAllAdressesQueryRequest : IRequest<List<GetAllAddressesQueryResponse>>
    {
    }
}
