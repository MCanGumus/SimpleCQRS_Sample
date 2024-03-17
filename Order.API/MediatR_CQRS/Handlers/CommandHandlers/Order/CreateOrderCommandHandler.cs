using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        public Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
