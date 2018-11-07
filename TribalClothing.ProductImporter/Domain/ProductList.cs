using System;
using System.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    class ProductList
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("# List products");

            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();
                foreach (var prod in products)
                {
                    Console.WriteLine($"{prod.Id} {prod.Name} {prod.Description} {prod.Price}");
                }  
            }

            Console.ReadLine();
        }
    }
}
