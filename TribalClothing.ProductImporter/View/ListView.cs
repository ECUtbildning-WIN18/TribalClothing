using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TribalClothing.ProductImporter.View
{
    class ListView
    {
        public static void Diaplay()
        {
            using (var context = new TribalClothingContext())
            {
                var productList = context.Products.ToList();

                Console.WriteLine($"Total products: {productList.Count}");
                Console.WriteLine($"{"PRODUCT NAME ",-20}{"PRODUCT DESCRIPTION"}");
                foreach (var product in productList)
                {
                    Console.WriteLine($"{product.Name,-20}{product.Description}");
                }

                Console.ReadKey();
                MainView.Display();

            }
        }
    }
}
