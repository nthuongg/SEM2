using Microsoft.EntityFrameworkCore;
using SupperMarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperMarketManagement.Data
{
    public class DataContext : DbContext 
    {
        private string _connectionString = "Server=DESKTOP-19DCDDQ\\SQLEXPRESS;Database=HuongDB;User Id=sa;Password=123456789;Trusted_Connection=True; TrustServerCertificate=True;MultipleActiveResultSets=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Membership>().HasData(
                    new Membership { Id = 1, Name = "Gold" },
                    new Membership { Id = 2, Name = "Platinum" },
                    new Membership { Id = 3, Name = "Silver" }
                );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }  
    }
}
