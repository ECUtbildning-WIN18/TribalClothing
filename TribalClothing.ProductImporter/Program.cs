using System;
using System.Xml.Schema;
using TribalClothing.ProductImporter.Domain;
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
