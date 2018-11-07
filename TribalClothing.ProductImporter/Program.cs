using Newtonsoft.Json;
using System;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Views;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new MainView();

            menu.StartView();
            
        }
    }
}
