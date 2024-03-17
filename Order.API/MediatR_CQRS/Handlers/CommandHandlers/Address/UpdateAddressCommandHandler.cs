using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Address
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, UpdateAddressCommandResponse>
    {
        public Task<UpdateAddressCommandResponse> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
