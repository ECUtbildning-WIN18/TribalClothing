using System;

namespace TribalClothing.ProductImporter.Domain.View
{
    internal class StartMenu
    {
        public void Display()
        {
            var isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("1. List product\n" +
                                  "2. Import from CSV\n" +
                                  "3. Import from JSON\n" +
                                  "4. Clear product catalog\n" +
                                  "5. Exit");

                var keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        isRunning = false;
                        var listProducts = new ListProductsFromDb();
                        listProducts.ListProducts();
                        isRunning = true;
                        break;
                    case ConsoleKey.D2:
                        var loadCsv = new ProductLoaderCsv();
                        loadCsv.ExportToDb();
                        StandardMessages.Success();
                        break;
                    case ConsoleKey.D3:
                        var loadJson = new ProductLoaderJson();
                        loadJson.ImportToDb();
                        StandardMessages.Success();
                        break;
                    case ConsoleKey.D4:
                        var clearCatalog = new ClearProductsFromDb();
                        clearCatalog.ClearDb();
                        StandardMessages.Success();
                        break;
                    case ConsoleKey.D5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            } while (isRunning);
        }
    }
}