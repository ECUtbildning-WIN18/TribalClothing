using System;
using System.IO;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter.Services
{
    class CSVimporter
    {
        public static void Import()
        {
            using (var reader = new StreamReader("..\\..\\..\\DataFiles\\Products.csv"))
            {
                var context = new TribalClothingContext();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var values = line.Split(';');

                    var name = values[1];

                    var description = values[2];

                    var price = Convert.ToDecimal(values[3]);

                    var product = new Product(name, description, price);

                    context.Products.Add(product);
                }

                context.SaveChanges();

                Console.Clear();
                Console.WriteLine("Products added from CSV, press any key");
                Console.ReadKey();

                MainView.Display();
            }
        }
    }
}
