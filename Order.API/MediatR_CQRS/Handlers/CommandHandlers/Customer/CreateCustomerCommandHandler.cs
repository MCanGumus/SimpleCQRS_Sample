using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Customer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        Task<CreateCustomerCommandResponse> IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>.Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
