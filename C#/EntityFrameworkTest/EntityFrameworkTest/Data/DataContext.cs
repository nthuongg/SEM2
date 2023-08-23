using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Data
{
    public class DataContext : DbContext

    {
        private string _connectionString = "Server=DESKTOP-19DCDDQ\\SQLEXPRESS;Database=HuongDB;User Id=sa;Password=123456789;Trusted_Connection=True; TrustServerCertificate=True;MultipleActiveResultSets=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Membership> Memberships { get; set; }
    }
}
