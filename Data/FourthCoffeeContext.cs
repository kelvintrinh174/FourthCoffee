using FourthCoffee.Models;
using FourthCoffee.Data.Configurations;
using Microsoft.EntityFrameworkCore;
namespace FourthCoffee.Data
{
    public class FourthCoffeeContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=FourthCoffee.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}