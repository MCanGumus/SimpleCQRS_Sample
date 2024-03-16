using Microsoft.EntityFrameworkCore;

namespace Order.API.Context
{
    public class OrderAPIDbContext : DbContext
    {
        public OrderAPIDbContext(DbContextOptions<OrderAPIDbContext> options) : base(options)
        {
        }


        public DbSet<Order.API.Entities.Order> Orders { get; set; }
        public DbSet<Order.API.Entities.Customer> Customers{ get; set; }
        public DbSet<Order.API.Entities.Address> Addresses { get; set; }
    }
}
