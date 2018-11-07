using System;
using System.Collections.Generic;
using System.Text;

namespace TribalClothing.ProductImporter.Domain.View
{
    class StartMenu
    {
        public void Display()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");

                var keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        isRunning = false;
                        var listProducts = new ListProductsFromDb();
                        listProducts.ListProducts();
                        break;
                    case ConsoleKey.D2:
                        //Import from CSV
                        break;
                    case ConsoleKey.D3:
                        var loadJson = new ProductLoaderJson();
                        loadJson.ImportToDb();
                        break;
                    case ConsoleKey.D4:
                        //Clear catalog
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

            } while (isRunning);
        }
    }
}
