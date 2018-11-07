using CsvHelper;
using System.IO;

namespace TribalClothing.ProductImporter.Domain.Services
{
    class ImportCSV
    {
        public void _ImportCSV(string csv_filepath)
        {
            using (var context = new TribalClothingContext())
            {
                using (StreamReader reader = new StreamReader(csv_filepath))
                {
                    var csvReader = new CsvReader(reader);
                    csvReader.Configuration.RegisterClassMap<ProductMapper>();
                    csvReader.Configuration.Delimiter = ";";
                    
                    var records = csvReader.GetRecords<Product>();

                    foreach (var record in records)
                    {
                        context.Products.Add(record);
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
