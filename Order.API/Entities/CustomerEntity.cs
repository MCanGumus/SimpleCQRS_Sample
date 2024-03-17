namespace Order.API.Entities
{
    public class CustomerEntity
    {
        public Guid CustomerId { get; set; }
        public required string Name{ get; set; }
        public required string Email { get; set; }
        public Guid AddressId { get; set; }
        public AddressEntity Address { get; set; }
        public DateTime CreatedAt{ get; set; }
        public DateTime? UpdatedAt { get; set; }

        ICollection<OrderEntity> Orders { get; set; }
    }
}
