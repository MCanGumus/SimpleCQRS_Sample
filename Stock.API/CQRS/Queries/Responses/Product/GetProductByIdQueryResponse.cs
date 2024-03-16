namespace Stock.API.CQRS.Queries.Responses.Product
{
    public class GetProductByIdQueryResponse
    {
        public required string ImageUrl { get; set; }
        public required string Name { get; set; }
        public int Quantity { get; set; }
    }
}
