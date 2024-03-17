using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Customer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, DeleteCustomerCommandResponse>
    {
        public Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
