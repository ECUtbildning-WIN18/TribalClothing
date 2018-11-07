using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace TribalClothing.ProductImporter.Domain
{
    class CSVLoader
    {

        List<Product> Products = new List<Product>();

        public List<Product> LoadFromCSV()
        {
            using (var reader = new StreamReader("Products.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    Products.Add(new Product( values[1], values[2], Convert.ToDecimal(values[3])));
                }
                foreach (var item in Products)
                {
                    Console.WriteLine($"Loaded Product {item.Id}");
                }
                Console.WriteLine("All Products Sucesfully loaded!");
                Thread.Sleep(2000);
            }

            return null;
        }

    }
}
