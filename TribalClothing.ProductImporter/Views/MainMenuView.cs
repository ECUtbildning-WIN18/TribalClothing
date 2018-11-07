using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage;
using Database = TribalClothing.ProductImporter.Domain.Database;

namespace TribalClothing.ProductImporter.Views
{
    class MainMenuView
    {
        public void Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog \n");
                Console.WriteLine("5. Quit");
                Console.Write("> ");

                var key = ConsoleKey.NoName;

                while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.D3 && key != ConsoleKey.D4 &&
                       key != ConsoleKey.D5 && key != ConsoleKey.Escape)
                {
                    key = Console.ReadKey(true).Key;
                }


                switch (key)
                {
                    case ConsoleKey.D1:
                    {
                        var products = new ListProductsView();
                        products.Display();
                        break;
                    }
                    case ConsoleKey.D2:
                    {
                        var csvImport = new ImportCsvView();
                        csvImport.Display();
                        break;
                    }
                    case ConsoleKey.D3:
                    {
                        var jsonImport = new ImportJsonView();
                        jsonImport.Display();
                        break;
                    }
                    case ConsoleKey.D4:
                    {
                        var resetTable = new ResetView();
                        resetTable.Display();
                        break;
                    }
                    case ConsoleKey.D5:
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }
}