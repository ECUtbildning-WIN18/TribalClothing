using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TribalClothing.ProductImporter.View
{
    class ListProduct
    {
        public void Display()
        {
            Console.WriteLine("List Product");

            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();

                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
