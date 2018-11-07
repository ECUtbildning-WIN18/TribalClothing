using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TribalClothing.ProductImporter.Views
{
    class MainMenu
    {
        private bool done = false;
        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" # Main menu\n");
                Console.WriteLine(" 1. List products");
                Console.WriteLine(" 2. Import from CSV");
                Console.WriteLine(" 3. Import from JSON");
                Console.WriteLine(" 4. Clear product catalog");
                Console.WriteLine(" 5. Exit");
                Console.Write(" > ");

                var choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.D1)
                {
                    var listProductView = new ListProductView();
                    listProductView.Display();
                }
                else if (choice.Key == ConsoleKey.D2)
                {
                    var importCsvView = new ImportCSVView();
                    importCsvView.Display();
                }
                else if (choice.Key == ConsoleKey.D3 || choice.Key == ConsoleKey.NumPad3)
                {
                    var importJSONView=new ImportJSONView();
                    importJSONView.Display();
                }
                else if (choice.Key == ConsoleKey.D4)
                {
                    var clearProductsView=new ClearProductsView();
                    clearProductsView.Display();
                }
                else if (choice.Key == ConsoleKey.D5)
                {
                    Console.Write("Exiting.");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                    Thread.Sleep(750);
                }
            } while (!done);
        }
    }
}
