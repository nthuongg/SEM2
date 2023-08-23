using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Models;

namespace SupermarketAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        // Khai bao ten cac bang trong database
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Membership>().HasData(
                new Membership()
                {
                    Id = 1,
                    Name = "Gold",
                },
                new Membership()
                {
                    Id = 2,
                    Name = "Silver",
                },
                new Membership()
                {
                    Id = 3,
                    Name = "Diamond",
                }

                );


        }
    }
}
