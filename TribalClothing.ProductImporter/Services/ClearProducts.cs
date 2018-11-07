using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TribalClothing.ProductImporter.Services
{
    class ClearProducts
    {
        public static void ClearList()
        {
            using (var db = new TribalClothingContext())
            {
                var productList = db.Products.ToList();

                foreach (var product in productList)
                {
                    db.Products.Remove(product);
                }

                Console.WriteLine("Product list cleared");

                db.SaveChanges();
            }
        }
    }
}
