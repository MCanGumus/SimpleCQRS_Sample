namespace Stock.API.ViewModels
{
    public class CreateProductVM
    {
        public required string ImageUrl { get; set; }
        public required string Name { get; set; }
        public int Quantity { get; set; }
    }
}
