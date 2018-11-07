using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.View
{
    class MenuView
    {
        public void Display()
        {
            

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
                        //userSearchView.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        //adminAddUserViewDB.Display();
                        var importFromCsv = new ImportFromCsv();
                        importFromCsv.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        var importFromJSON = new ImportFromJSON();
                        importFromJSON.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        //loginView.Display();
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
