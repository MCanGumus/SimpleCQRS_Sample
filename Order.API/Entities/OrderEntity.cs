using System.ComponentModel.DataAnnotations;

namespace Order.API.Entities
{
    public class OrderEntity
    {
        [Key]
        public Guid OrderId { get; set; }

        public Guid CustomerId { get; set; }
        public CustomerEntity Customer{ get; set; }

        [Required(ErrorMessage = "Count is required")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Count must be a numeric value")]
        public int Count { get; set; }

        [Required(ErrorMessage = "TotalPrice is required")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "TotalPrice must be a numeric value")]
        public decimal TotalPrice { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }
        public Guid ProductId { get; set; }
        public Guid AddressId { get; set; }
        public AddressEntity Address { get; set; }
        

        public DateTime CreatedDate { get; set;}
        public DateTime? UpdatedDate { get; set;}

    }
}
