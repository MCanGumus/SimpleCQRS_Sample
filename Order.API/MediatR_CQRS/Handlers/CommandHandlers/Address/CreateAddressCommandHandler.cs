using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Address
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressCommandResponse>
    {
        public Task<CreateAddressCommandResponse> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
