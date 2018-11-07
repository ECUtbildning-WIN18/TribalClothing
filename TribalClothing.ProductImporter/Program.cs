using System;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Domain.View;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            var startMenu = new StartMenu();
            startMenu.Display();

            Console.ReadKey();
        }
    }
}
