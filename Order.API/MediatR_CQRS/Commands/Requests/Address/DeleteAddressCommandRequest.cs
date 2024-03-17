using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Commands.Requests.Address
{
    public class DeleteAddressCommandRequest : IRequest<DeleteAddressCommandResponse>
    {
        public Guid AddressId { get; set; }
    }
}
