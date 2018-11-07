using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace TribalClothing.ProductImporter.Domain
{
    public class ProductLoaderCsv
    {
        public void ExportToDb()
        {
            TextReader reader = new StreamReader(@"C:\Workspace\ECUtbildning\TribalClothing\TribalClothing.ProductImporter\ProductsCsv.csv");

            var csv = new CsvReader(reader);
            csv.Configuration.Delimiter = ";";

            var records = csv.GetRecords<Product>();
            var products = new List<Product>();
            foreach (var product in records)
            {
                product.Id = 0;
                products.Add(product);
            }

            using (var context = new TribalClothingContext())
            {
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}