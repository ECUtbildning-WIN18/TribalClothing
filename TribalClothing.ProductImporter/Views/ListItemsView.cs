using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Views.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ListItemsView : BaseView
    {
        public ListItemsView() : base("List Items")
        {
            
        }

        public void Run()
        {
            var products = GetItems();
            Console.WriteLine($"Total Products: {products.Count}");
            Console.WriteLine("PRODUCT NAME\t\t\tPRODUCT DESCRIPTION");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name}\t\t\t{p.Description}");
            }

            Console.WriteLine("Press return to go back");
            Console.ReadLine();
        }

        private IList<Product> GetItems()
        {
            using (var context = new TribalClothingContext())
            {
                return context.Products.ToList();
            }
        }
    }
}