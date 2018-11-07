using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class ProductView
    {
        public void Display()
        {
            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();

                Console.WriteLine($"\nTotal Products: {products.Count}");
                Console.WriteLine("\nProduct Name\t \t Product Description");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Name}\t \t {product.Description}");
                }
            }

            Console.WriteLine("press any key to return");
            Console.ReadKey(true);

        }
    }
}
