using System;
using System.Collections.Generic;
using System.Text;

namespace TribalClothing.ProductImporter.View
{
    class MainMenu
    {
        public void Display()
        {
            int menuChoice = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose by following options");
                Console.WriteLine("\n1. List all products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalouge");

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
                        Console.WriteLine("List Products");
                        Console.ReadKey();
                        //DataHelper.ListProducts();
                        break;

                    case 2:
                        Console.WriteLine("Import from CSV");
                        Console.ReadKey();
                        //DataHelper.ImportFromCSVFile(inparameter);
                        break;

                    case 3:
                        Console.WriteLine("Import from JSON");
                        Console.ReadKey();
                        //DataHelper.ImportFromJSONFile(inparameter);
                        break;

                    case 4:
                        Console.WriteLine("Clear Product");
                        Console.ReadKey();
                        //DataHelper.ClearProductCatalog();
                        break;

                    default:
                        Console.WriteLine("You can only choose by numbers 1-4");
                        break;
                }
            }
        }
    }
}
