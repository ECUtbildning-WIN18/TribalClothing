using System;
using System.IO;
using System.Linq;
using System.Threading;
using CsvHelper;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter.Services
{
    class CSVHelper
    {
        public void GetProduct()
        {
            TextReader reader = new StreamReader("Product.csv");

            var csvReader = new CsvReader(reader);
            csvReader.Configuration.RegisterClassMap<ProductMapper>();
            csvReader.Configuration.Delimiter = ";";

            var records = csvReader.GetRecords<Product>().ToList();

            using (var context = new TribalClothingContext())
            {
                context.Products.AddRange(records);
                context.SaveChanges();
            }

            Console.Clear();
            Console.WriteLine("\nImport Success!");
            Thread.Sleep(2000);
            MainMenuView.Display();
        }
    }
}
