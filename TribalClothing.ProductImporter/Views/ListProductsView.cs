using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TribalClothing.ProductImporter.Views
{
    class ListProductsView
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Products: \n");

            using (var db = new TribalClothingContext())
            {
                var productList = db.Products.ToList();

                foreach(var product in productList)
                {
                    Console.WriteLine($"{product.Name} {product.Description} {product.Price}\n");
                }
            }
        }
    }
}
