using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.View
{
    class MenuView
    {
        // US01: As a user I want to see a menu when starting the application so I can choose what action to take
        public void Display()
        {
            var importFromJSON = new ImportFromJSON();

            Console.WriteLine("1. List products");
            Console.WriteLine("2. Import from CSV");
            Console.WriteLine("3. Import from JSON");
            Console.WriteLine("4. Clear product catalog");

            var menuInputLoop = true;
            while (menuInputLoop)
            {
                var menuInputKey = Console.ReadKey();
                Console.WriteLine();
                switch (menuInputKey.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        //List Product
                        var listProduct = new ListProduct();
                        listProduct.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        //Import from CSV
                        var importFromCsv = new ImportFromCsv();
                        importFromCsv.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();

                        importFromJSON.ImportJSON();

                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        //Clear Product Catalog
                        var clearProductCatalog = new ClearProductCatalog();
                        clearProductCatalog.Display();
                        menuInputLoop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input!");
                        Console.Write("Try again: ");
                        break;
                }
            }
        }
    }
}
