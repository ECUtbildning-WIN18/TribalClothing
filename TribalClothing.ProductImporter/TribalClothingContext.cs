using Microsoft.EntityFrameworkCore;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter
{
    class TribalClothingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=TribalClothing;Integrated Security=True;");
            optionsBuilder.UseSqlServer("Server=.\\STEFANSQLSERVER;Database=TribalClothing;Integrated Security=True;");

        }

        public DbSet<Product> Products { get; set; }
    }
}
