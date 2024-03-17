using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Customer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        public Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
