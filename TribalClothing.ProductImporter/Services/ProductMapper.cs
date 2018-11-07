using CsvHelper.Configuration;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.Services
{
sealed class ProductMapper : ClassMap<Product>
{
public ProductMapper()
{
Map(m => m.Name);
Map(m => m.Description);
Map(m => m.Price);
}
}
}