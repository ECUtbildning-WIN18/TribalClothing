using System;
using System.IO;
using CsvHelper;

namespace TribalClothing.ProductImporter.Domain
{
    class ImportCSV
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("# Import from CSV");
            ImportCsv();
           
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
            Console.WriteLine("Import process done! press any button to continue.");
            Console.ReadKey();

            var menu = new MenuView();
            menu.Display();
        }
    }
}
