using MediatR;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Address;
using Order.API.MediatR_CQRS.Commands.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Address
{
    public class CreateAddressCommandHandler(OrderAPIDbContext context) : IRequestHandler<CreateAddressCommandRequest, CreateAddressCommandResponse>
    {
        public async Task<CreateAddressCommandResponse> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            AddressEntity address = new()
            {
                AddressId = Guid.NewGuid(),
                City = request.City,
                CityCode = request.CityCode,
                Country = request.Country,
                AddressLine = request.AddressLine,
            };

            context.Addresses.Add(address);

            await context.SaveChangesAsync();

            return new CreateAddressCommandResponse { AddressId = address.AddressId};
        }
    }
}
