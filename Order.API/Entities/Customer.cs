namespace Order.API.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public required string Name{ get; set; }
        public required string Email { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public DateTime CreatedAt{ get; set; }
        public DateTime? UpdatedAt { get; set; }

        ICollection<Order> Orders { get; set; }
    }
}
