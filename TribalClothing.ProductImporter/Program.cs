﻿using System;
using System.Linq;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            MainView.Display();
        }

        static public void Test()
        {
            using (var context = new TribalClothingContext())
            {
                Console.WriteLine("test");

                var list = context.Products.ToList();


                foreach (var a in list)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }
    }
}
