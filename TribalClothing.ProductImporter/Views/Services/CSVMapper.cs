using CsvHelper.Configuration;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.Views.Services
{
    sealed class CSVMapper : ClassMap<Product>
    {
        public CSVMapper()
        {
            Map(m => m.Name);
            Map(m => m.Description);
            Map(m => m.Price);
        }
    }
}