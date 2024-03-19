using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Order.API.Entities
{
    public class AddressEntity
    {
        [Key]
        public Guid AddressId { get; set; }

        public string? AddressLine { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Country must contain only letters")]
        public string Country { get; set; }

        [Required(ErrorMessage = "CityCode is required")]
        public string CityCode { get; set; }

        ICollection<OrderEntity> Orders { get; set; }
    }
}
