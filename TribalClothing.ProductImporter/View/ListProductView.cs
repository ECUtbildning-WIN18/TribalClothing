using System;
using System.Linq;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace TribalClothing.ProductImporter.View
{
    class ListProductView
    {
        private int count = 0;

        public void Display()
        {
            Console.Clear();
            Console.Write($"Total products: {count}");
            Console.WriteLine("\nPRODUCT NAME         PRODUCT DESCRIPTION");
            ListProduct();

            Console.ReadKey();
        }

        public void ListProduct()
        {
            using (var db = new TribalClothingContext())
            {
                var productList = db.Products.ToList();

                foreach (var product in productList)
                {
                    Console.WriteLine($"{product.Name}          {product.Description}");   
                }
            }
        }
    }
}
