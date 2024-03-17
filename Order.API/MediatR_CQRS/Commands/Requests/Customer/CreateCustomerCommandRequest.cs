using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Commands.Requests.Customer
{
    public class CreateCustomerCommandRequest : IRequest<CreateCustomerCommandResponse>
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public Guid AddressId { get; set; }
    }
}
