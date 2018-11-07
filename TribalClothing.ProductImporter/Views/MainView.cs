using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.Views
{
    class MainView
    {
        public void StartView()
        {
            bool menu = true;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");

                string menuChoise = Console.ReadLine();

                switch (menuChoise)
                {
                    case "1":
                        {
                            var printUser = new PrintUser();
                            
                            var listUser = printUser.GetUsers();

                            foreach (var product in listUser)
                            {
                                Console.WriteLine($"{product.Name} {product.Description } {product.Price}");
                            }
                            Console.ReadLine();
                            
                            break;
                        }
                    case "2":
                        {
                            TextReader reader = new StreamReader("Products.CSV");
                            var csvReader = new CsvReader(reader);
                            csvReader.Configuration.Delimiter = ";";
                            var records = csvReader.GetRecords<Product>();
                            var products = new List<Product>();

                            foreach (var p in records)
                            {
                                p.Id = 0;
                                products.Add(p);
                            }

                            using (var context = new TribalClothingContext())
                            {
                                context.Products.AddRange(products);
                                context.SaveChanges();
                            }

                            break;
                        }
                    case "3":
                        {
                            Console.Clear();

                            var product = new Product();

                            var load = new LoadJson();
                            load.ReadJson();
                            
                            break;
                        }
                    case "4":
                        {
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
