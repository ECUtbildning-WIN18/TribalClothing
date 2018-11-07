using System;
using System.Collections.Generic;
using System.Text;
using TribalClothing.ProductImporter.Views.Services;

namespace TribalClothing.ProductImporter.Views
{
    class MainView : BaseView
    {
        public MainView() : base("Main Menu", 1)
        {
            
        }

        public void Run()
        {
            ConsoleKey input;
            do
            {
                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        var liv = new ListItemsView();
                        liv.Run();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Press return to exit application");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option\nPress reutn to restart");
                        Console.ReadLine();
                        break;
                }
            } while (input != ConsoleKey.Escape);
        }
    }
}
