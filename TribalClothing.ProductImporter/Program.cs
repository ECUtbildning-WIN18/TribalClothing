using System;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu Menu = new MainMenu();
            while (true)
                Menu.Display();
        }
    }
}
