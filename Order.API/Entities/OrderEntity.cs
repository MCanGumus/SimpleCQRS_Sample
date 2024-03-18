using System.ComponentModel.DataAnnotations;

namespace Order.API.Entities
{
    public class OrderEntity
    {
        [Key]
        public Guid OrderId { get; set; }

        public Guid CustomerId { get; set; }
        public CustomerEntity Customer{ get; set; }

        public int Count{ get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public Guid ProductId { get; set; }
        public Guid AddressId { get; set; }
        public AddressEntity Address { get; set; }
        

        public DateTime CreatedDate { get; set;}
        public DateTime? UpdatedDate { get; set;}

    }
}
