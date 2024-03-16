namespace Order.API.Entities
{
    public class Address
    {
        public Guid AddressId{ get; set; }
        public string? AddressLine { get; set; }
        public required string  City{ get; set; }
        public required string Country { get; set; }
        public required string CityCode{ get; set; }

        ICollection<Order> Orders { get; set; }
    }
}
