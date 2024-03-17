namespace Order.API.MediatR_CQRS.Queries.Responses.Customer
{
    public class GetCustomerByIdQueryResponse
    {
        public Guid CustomerId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public Guid AddressId { get; set; }
    }
}
