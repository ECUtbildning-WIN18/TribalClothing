using System;

namespace TribalClothing.ProductImporter.View
{
    class MainMenuView
    {
        public void Display()
        {
            var isRunning = true;

            do
            {
                Console.Clear();

                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");

                var consoleKeyInfo = Console.ReadKey();

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        var listProduct = new ListProductView();
                        listProduct.Display();

                        break;
                    case ConsoleKey.D2:
                        
                        break;
                    case ConsoleKey.D3:

                        break;
                    case ConsoleKey.D4:

                        break;
                    default:
                        break;
                }

            } while (!isRunning);
        }
    }
}
