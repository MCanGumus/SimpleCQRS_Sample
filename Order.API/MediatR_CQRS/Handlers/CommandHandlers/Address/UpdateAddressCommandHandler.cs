using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Address
{
    public class UpdateAddressCommandHandler(OrderAPIDbContext context) : IRequestHandler<UpdateAddressCommandRequest, UpdateAddressCommandResponse>
    {
        public async Task<UpdateAddressCommandResponse> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            AddressEntity address = await context.Addresses.FirstOrDefaultAsync(x => x.AddressId == request.AddressId);

            if (address == null) { return new UpdateAddressCommandResponse { IsSuccess = true }; }

            address.AddressLine = request.AddressLine;
            address.CityCode = request.CityCode;
            address.City = request.City;
            address.Country = request.Country;

            context.Addresses.Update(address);
            await context.SaveChangesAsync();

            return new UpdateAddressCommandResponse { IsSuccess = true };
        }
    }
}
