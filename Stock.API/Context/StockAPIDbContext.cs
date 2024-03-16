using Microsoft.EntityFrameworkCore;

namespace Stock.API.Context
{
    public class StockAPIDbContext : DbContext
    {
        public StockAPIDbContext(DbContextOptions<StockAPIDbContext> options) : base(options)
        {
        }
        public DbSet<Stock.API.Entities.Product> Products{ get; set; }
    }
}
