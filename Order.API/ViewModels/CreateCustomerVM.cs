using Order.API.Entities;

namespace Order.API.ViewModels
{
    public class CreateCustomerVM
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public Guid AddressId { get; set; }
    }
}
