using System;
using System.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    internal class ListProductsFromDb
    {
        public void ListProducts()
        {
            Console.Clear();

            var productList = new TribalClothingContext().Products.ToList();

            if (productList.Count != 0)
            {
                Console.WriteLine($"Total amount of products:{productList.Count}\n");
                Console.WriteLine("Product Name\tProduct Description\n");

                foreach (var product in productList) Console.WriteLine($"{product.Name}\t{product.Description}");
            }
            else
            {
                Console.WriteLine("No products to list, try importing first.\n");
            }

            Console.WriteLine("\nPress any key to go back to previous menu");
            Console.ReadKey(true);
        }
    }
}