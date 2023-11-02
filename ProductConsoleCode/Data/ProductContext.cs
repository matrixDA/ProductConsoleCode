using Microsoft.EntityFrameworkCore;
using ProductConsoleCode.Models;

namespace ProductConsoleCode.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProductDb;Trusted_Connection=true; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product { Id = 1, Price = 200m, Description = "My first product" },
                new Product { Id = 2, Price = 150m, Description = "My second product"}
                );
        }
    }
}
