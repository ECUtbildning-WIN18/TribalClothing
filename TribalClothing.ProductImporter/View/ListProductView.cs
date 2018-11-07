using System;
using System.Linq;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace TribalClothing.ProductImporter.View
{
    class ListProductView
    {
        public void Display()
        {
            int count = 0;
            
            Console.Clear();
            Console.WriteLine($"Total products: {count}"); // EJ KLAAAAR!!!
            Console.WriteLine("\nPRODUCT NAME               PRODUCT DESCRIPTION");

            using (var db = new TribalClothingContext())
            {
                var productList = db.Products.ToList();

                foreach (var product in productList)
                {
                    Console.WriteLine($"{product.Name}                   {product.Description}");
                    count += 1;
                }
            }

            Console.ReadKey();
        }
    }
}
