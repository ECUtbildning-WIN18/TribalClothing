using System;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {

            LoadJson.ReadJson();
            Console.ReadLine();
        }
    }
}
