using System.ComponentModel.DataAnnotations;

namespace Stock.API.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId{ get; set; }
        [Required(ErrorMessage = "Image is required")]
        public required string ImageUrl { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity{ get; set; }
    }
}
