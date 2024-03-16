namespace Stock.API.CQRS.Commands.Requests.Product
{
    public class UpdateProductCommandRequest 
    {
        public Guid ProductId { get; set; }
        public required string ImageUrl { get; set; }
        public required string Name { get; set; }
        public int Quantity { get; set; }
    }
}
