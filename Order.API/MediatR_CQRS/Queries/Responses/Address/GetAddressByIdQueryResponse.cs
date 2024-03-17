namespace Order.API.MediatR_CQRS.Queries.Responses.Address
{
    public class GetAddressByIdQueryResponse
    {
        public Guid AddressId { get; set; }
        public string? AddressLine { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string CityCode { get; set; }
    }
}
