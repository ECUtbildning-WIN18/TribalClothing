using System;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Services;

namespace TribalClothing.ProductImporter.View
{
    class MainView
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("1. List products");
            Console.WriteLine("2. Import from CSV");
            Console.WriteLine("3. Import from JSON");
            Console.WriteLine("4. Clear product catalog");

            var choice = Console.ReadKey(true).Key;
            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ListView.Display();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    CSVimporter.Import();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    LoadJson.ReadJson();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    ClearProducts.ClearList();
                    break;
            }
        }
    }
}
