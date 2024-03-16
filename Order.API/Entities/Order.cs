namespace Order.API.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer{ get; set; }

        public int Count{ get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public Guid ProductId { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        

        public DateTime CreatedDate { get; set;}
        public DateTime? UpdatedDate { get; set;}

    }
}
