using System;
using TribalClothing.ProductImporter.Domain.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ListProductView
    {
        public void Display()
        {
            Console.Clear();
            var products = new ListProducts();

            Console.WriteLine($" Total products: {products._ListProducts().Count}");
            Console.WriteLine("\n PRODUCT NAME                     PRODUCT DESCRIPTION");
            foreach (var product in products._ListProducts())
            {
                Console.WriteLine($"{product.Name}                    {product.Description}");
            }
        }
    }
}