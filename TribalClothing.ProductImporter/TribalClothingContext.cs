using Microsoft.EntityFrameworkCore;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter
{
    class TribalClothingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=TribalClothing;user id=SA; pwd=Ryan2134!");
        }

        public DbSet<Product> Products { get; set; }
    }
}
