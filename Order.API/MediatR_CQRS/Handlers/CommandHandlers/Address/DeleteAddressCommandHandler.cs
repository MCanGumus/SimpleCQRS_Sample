using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Address
{
    public class DeleteAddressCommandHandler(OrderAPIDbContext context) : IRequestHandler<DeleteAddressCommandRequest, DeleteAddressCommandResponse>
    {
        public async Task<DeleteAddressCommandResponse> Handle(DeleteAddressCommandRequest request, CancellationToken cancellationToken)
        {
            AddressEntity address = await context.Addresses.FirstOrDefaultAsync(x => x.AddressId == request.AddressId);

            if (address == null)
            {
                return new DeleteAddressCommandResponse { IsSuccess = false };
            }
            context.Addresses.Remove(address);

            await context.SaveChangesAsync();

            return new DeleteAddressCommandResponse { IsSuccess = true};
        }
    }
}
