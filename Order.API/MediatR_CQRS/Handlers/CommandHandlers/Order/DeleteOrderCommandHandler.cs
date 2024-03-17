using MediatR;
using Order.API.MediatR_CQRS.Commands.Requests.Order;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Order
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
    {
        public Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
