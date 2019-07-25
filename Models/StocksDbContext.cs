using Microsoft.EntityFrameworkCore;

namespace StockManagment.Models
{
    public class StocksDbContext :DbContext
    {
        public StocksDbContext(DbContextOptions<StocksDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        public DbSet<Broker> Brokers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Stock> Stocks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
