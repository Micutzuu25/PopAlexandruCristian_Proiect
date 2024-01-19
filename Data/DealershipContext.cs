using Microsoft.EntityFrameworkCore;
using PopAlexandru_Proiect2.Models;


namespace PopAlexandruCristian_Proiect.Data
{
    public class DealershipContext : DbContext
    {
        public DealershipContext(DbContextOptions<DealershipContext> options) :
base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublishedCar> PublishedCars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<PublishedCar>().ToTable("PublishedCar");
            modelBuilder.Entity<PublishedCar>()
            .HasKey(c => new { c.CarID, c.PublisherID });//configureaza cheia primara compusa
        }

    }
}
