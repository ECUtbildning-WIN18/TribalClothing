using Microsoft.EntityFrameworkCore;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter
{
    internal class TribalClothingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TribalClothing;Integrated Security=True;");
        }
    }
}