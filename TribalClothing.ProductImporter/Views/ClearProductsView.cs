using System;
using System.Threading;
using TribalClothing.ProductImporter.Domain.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ClearProductsView
    {
        public void Display()
        {
            var done = false;
            do
            {
                Console.Clear();
                Console.Write(" Delete all products? (Y)es (N)o >");
                var confirm = Console.ReadKey(true);

                if (confirm.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\n\nAre you sure?  (H)ell yes  (N)o");
                    var confirm2 = Console.ReadKey(true);

                    if (confirm2.Key == ConsoleKey.H)
                    {
                        var clearProducts = new ClearProducts();
                        clearProducts._ClearProducts();

                        Console.Write("\nDeleting.");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        Thread.Sleep(250); Console.Write(".");
                        done = true;
                    }
                }
                else
                {
                    done = true;
                }
            } while (!done);
        }
    }
}
