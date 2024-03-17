using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Address
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, DeleteAddressCommandResponse>
    {
        public Task<DeleteAddressCommandResponse> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
