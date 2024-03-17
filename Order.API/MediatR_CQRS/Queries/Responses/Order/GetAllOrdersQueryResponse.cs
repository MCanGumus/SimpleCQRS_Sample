namespace Order.API.MediatR_CQRS.Queries.Responses.Order
{
    public class GetAllOrdersQueryResponse
    {
        public Guid OrderId { get; set; }

        public Guid CustomerId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public Guid ProductId { get; set; }
        public Guid AddressId { get; set; }
    }
}
