using System;
using TribalClothing.ProductImporter.Services;

namespace TribalClothing.ProductImporter.View
{
    class MainMenuView
    {
        public static void Display()
        {
            var isRunning = true;

            do
            {
                Console.Clear();

                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");

                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        var listProduct = new ListProductView();
                        listProduct.Display();

                        break;
                    case ConsoleKey.D2:
                        var importCsv = new CSVHelper();
                        importCsv.GetProduct();

                        break;
                    case ConsoleKey.D3:
                        var getProduct = new JSONHelper();
                        getProduct.GetProduct();
                        Console.ReadKey();

                        break;
                    case ConsoleKey.D4:
                        var clearList = new ClearList();
                        clearList.RemoveProducts();

                        break;
                    default:
                        break;
                }

            } while (!isRunning);
        }
    }
}
