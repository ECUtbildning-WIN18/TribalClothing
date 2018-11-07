using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using CsvHelper;

namespace TribalClothing.ProductImporter.Domain
{
    public class ProductLoaderCsv
    {
        public void ExportToDb()
        {
            TextReader reader = new StreamReader("ProductsCsv.csv");
           
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