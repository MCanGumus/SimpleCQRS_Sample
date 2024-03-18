using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.MediatR_CQRS.Queries.Requests.Address;
using Order.API.MediatR_CQRS.Queries.Responses.Address;

namespace Order.API.MediatR_CQRS.Handlers.QueryHandlers.Address
{
    public class GetAllAddressesQueryHandler(OrderAPIDbContext context) : IRequestHandler<GetAllAdressesQueryRequest, List<GetAllAddressesQueryResponse>>
    {
        public async Task<List<GetAllAddressesQueryResponse>> Handle(GetAllAdressesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = context.Addresses.ToList();
            return await context.Addresses.Select(x => new GetAllAddressesQueryResponse
            {
                City = x.City,
                CityCode = x.CityCode,
                Country = x.Country,
                AddressId = x.AddressId,
                AddressLine = x.AddressLine,
            }).ToListAsync();
        }
    }
}
