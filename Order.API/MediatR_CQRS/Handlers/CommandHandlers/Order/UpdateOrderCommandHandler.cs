using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        public Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
