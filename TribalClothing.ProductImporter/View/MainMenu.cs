using System;
using TribalClothing.ProductImporter.Services;

namespace TribalClothing.ProductImporter.View
{
    class MainMenu
    {
        public void Display()
        {
            int menuChoice = 0;
            var productList = DataHelper.GetProductsFromDb();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose by following options");
                Console.WriteLine("\n1. List all products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");
                Console.WriteLine("5. Exit the application");

                try
                {
                    menuChoice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    menuChoice = 0;
                }

                switch (menuChoice)
                {
                    case 1:

                        DataHelper.ListProducts(DataHelper.GetProductsFromDb());
                        Console.ReadKey();
                        break;

                    case 2:

                        DataHelper.StoreProductsToDb(DataHelper.ImportFromCSVFile());
                        Console.WriteLine("Import completed");
                        Console.ReadKey();
                        break;

                    case 3:
                        DataHelper.StoreProductsToDb(DataHelper.ImportFromJSONFile());
                        Console.WriteLine("Import completed");
                        Console.ReadKey();
                        break;

                    case 4:
                        DataHelper.ClearProductCatalog();
                        Console.WriteLine("All items are deleted");
                        Console.ReadKey();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You can only choose by numbers 1-5");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
