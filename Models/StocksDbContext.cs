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

        public PeopleBrokers PeopleBrokers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeopleBrokers>().HasKey(pb => new { pb.PersonId, pb.BrokerId });
            modelBuilder.Entity<PeopleBrokers>().HasOne(p => p.Person).WithMany(p => p.PeopleBrokers).HasForeignKey(p=>p.PersonId);
            modelBuilder.Entity<PeopleBrokers>().HasOne(b => b.Broker).WithMany(p => p.PeopleBrokers).HasForeignKey(b=>b.BrokerId);
        }
    }
}
