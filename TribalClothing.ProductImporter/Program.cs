using System;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            MainView.Display();
            Console.ReadKey();
            Console.WriteLine("Press any key to exit");
        }
    }
}
