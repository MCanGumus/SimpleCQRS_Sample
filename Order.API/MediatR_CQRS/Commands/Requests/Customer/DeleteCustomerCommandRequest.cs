using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Commands.Requests.Customer
{
    public class DeleteCustomerCommandRequest : IRequest<DeleteCustomerCommandResponse>
    {
        public Guid CustomerId { get; set; }
    }
}
