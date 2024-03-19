using System.ComponentModel.DataAnnotations;

namespace Order.API.Entities
{
    public class CustomerEntity
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        
        public Guid AddressId { get; set; }
        public AddressEntity Address { get; set; }
        public DateTime CreatedAt{ get; set; }
        public DateTime? UpdatedAt { get; set; }

        ICollection<OrderEntity> Orders { get; set; }
    }
}
