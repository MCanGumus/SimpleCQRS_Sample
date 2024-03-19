using Microsoft.EntityFrameworkCore;
using Order.API.Entities;

namespace Order.API.Context
{
    public class OrderAPIDbContext : DbContext
    {
        public OrderAPIDbContext(DbContextOptions<OrderAPIDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>()
                .Property(o => o.TotalPrice)
                .HasColumnType("decimal(18,2)");  // Example for 18 digits with 2 decimal places
        }

        public DbSet<Order.API.Entities.OrderEntity> Orders { get; set; }
        public DbSet<Order.API.Entities.CustomerEntity> Customers{ get; set; }
        public DbSet<Order.API.Entities.AddressEntity> Addresses { get; set; }
    }
}
