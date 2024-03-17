using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Commands.Requests.Address
{
    public class CreateAddressCommandRequest : IRequest<CreateAddressCommandResponse>
    {
        public string? AddressLine { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string CityCode { get; set; }
    }
}
