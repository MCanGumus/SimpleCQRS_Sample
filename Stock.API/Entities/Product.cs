namespace Stock.API.Entities
{
    public class Product
    {
        public Guid ProductId{ get; set; }
        public required string ImageUrl { get; set; }
        public required string Name { get; set; }
        public int Quantity{ get; set; }
    }
}
