using System;
using TribalClothing.ProductImporter.Views;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new MainMenuView();
            mainMenu.Display();
            Console.ReadKey();
        }
    }
}
