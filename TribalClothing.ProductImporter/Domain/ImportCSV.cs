using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using Microsoft.EntityFrameworkCore;

namespace TribalClothing.ProductImporter.Domain
{
    class ImportCSV
    {

        public void Display()
        {
            Console.Clear();
            ImportCsv();
            Console.WriteLine("# Import from CSV");
            
        }
        static void ImportCsv()
        {
            TextReader reader = new StreamReader("Products.csv");
            var csvReader = new CsvReader(reader);
            csvReader.Configuration.RegisterClassMap<ProductMapper>();
            csvReader.Configuration.Delimiter = ";";

            var records = csvReader.GetRecords<Product>();

            using (var context = new TribalClothingContext())
            {
                context.Products.AddRange(records);
                context.SaveChanges();

                foreach ( var product in records)
                {
                    Console.WriteLine($"{product.Id} {product.Name} {product.Description} {product.Price}"); 
                }
               
            }
            Console.ReadLine();         
        }

        public void storeProductCsv()
        {
            using (var context = new TribalClothingContext())
            {
               // var product = new Product("Peruvian 1", "Lorum ipsum", 100);

                //context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateCsv()
        {
            using (var context = new TribalClothingContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Id == 1);

                if (product != null)
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
        }

        public void RemoveAllProducts()
        {
            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            }
        }
    }
}
