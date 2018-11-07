using Microsoft.EntityFrameworkCore;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter
{
    class TribalClothingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-5V8GU1UJ\\SQLEXPRESS;Database=TribalClothingDB;Integrated Security=True;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
