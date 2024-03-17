using Microsoft.EntityFrameworkCore;

namespace Order.API.Context
{
    public class OrderAPIDbContext : DbContext
    {
        public OrderAPIDbContext(DbContextOptions<OrderAPIDbContext> options) : base(options)
        {
        }


        public DbSet<Order.API.Entities.OrderEntity> Orders { get; set; }
        public DbSet<Order.API.Entities.CustomerEntity> Customers{ get; set; }
        public DbSet<Order.API.Entities.AddressEntity> Addresses { get; set; }
    }
}
