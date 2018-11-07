using System;
using System.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    class ListProductsFromDb
    {
        public void ListProducts()
        {
            Console.Clear();

            var productList = new TribalClothingContext().Products.ToList();

            Console.WriteLine($"Total amount of products:{productList.Count}\n");
            Console.WriteLine($"Product Name\tProduct Description\n");

            foreach (var product in productList)
            {
                Console.WriteLine($"{product.Name}\t{product.Description}");
            }
        }
    }
}
