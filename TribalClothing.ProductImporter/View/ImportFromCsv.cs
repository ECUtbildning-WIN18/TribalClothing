using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.View
{
    class ImportFromCsv
    {
        // US03: As a user I want to be able to import product data from CSV so that I may populate the product catalog
        List<Product> Products = new List<Product>();

        public void Display()
        {
            Console.WriteLine("Import from CSV");
            using (var reader = new StreamReader("Import.CSV"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(";");
                    Products.Add(new Product(values[1], values[2], Convert.ToDecimal (values[3])));
                }
            }

            using (var context = new TribalClothingContext())
            {
                foreach (var item in Products)
                {
                    var product = new Product(item.Name, item.Description, item.Price);
                    context.Products.Add(product);
                    context.SaveChanges();
                    
                }
            }
        }

    }
}
