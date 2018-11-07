using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Services;

namespace TribalClothing.ProductImporter.View
{
    class MainView
    {
        public static void  Display()
        {
            Console.WriteLine("1. List products");
            Console.WriteLine("2.Import from CSV");
            Console.WriteLine("3.Import from JSON");
            Console.WriteLine("4.Clear product catalog");

            var choice = Console.ReadKey(true).Key;
            switch (choice)
            {
                case ConsoleKey.D1:
                    ListView.Display();
                    break;
                case ConsoleKey.D2:
                    CSVimporter.import();
                    break;
                case ConsoleKey.D3:
                    LoadJson.ReadJson();
                    break;
                case ConsoleKey.D4:
                    ClearProducts.ClearList();
                    break;

            }
        }

    }
}
