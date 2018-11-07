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
            // US02: As a user I want to be able to list all current products in the product catalog so that I can see what’s been imported
            Console.WriteLine("List Product");

            // skapa lista som visar importerad information från databasen - JSON och CSV
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
