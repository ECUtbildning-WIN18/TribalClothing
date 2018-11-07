using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");

                string menuChoise = Console.ReadLine();

                switch (menuChoise)
                {
                    case "1":
                        {
                            break;
                        }
                    case "2":
                        {
                            TextReader reader = new StreamReader("Products.CSV");
                            var csvReader = new CsvReader(reader);
                            var records = csvReader.GetRecords<Product>();

                            break;
                        }
                    case "3":
                        {
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
