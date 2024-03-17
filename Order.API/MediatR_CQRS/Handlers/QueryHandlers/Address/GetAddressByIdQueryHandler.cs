using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Queries.Requests.Address;
using Order.API.MediatR_CQRS.Queries.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Address
{
    public class GetAddressByIdQueryHandler(OrderAPIDbContext context) : IRequestHandler<GetAddressByIdQueryRequest, GetAddressByIdQueryResponse>
    {
        public async Task<GetAddressByIdQueryResponse> Handle(GetAddressByIdQueryRequest request, CancellationToken cancellationToken)
        {
            AddressEntity addressEntity = await context.Addresses.FirstOrDefaultAsync(x => x.AddressId == request.AddressId);

            return new GetAddressByIdQueryResponse()
            {
                City = addressEntity.City,
                AddressId = addressEntity.AddressId,
                CityCode = addressEntity.CityCode,
                AddressLine = addressEntity.AddressLine,
                Country = addressEntity.Country
            };
        }
    }
}
