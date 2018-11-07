using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TribalClothing.ProductImporter.View;

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
                db.SaveChanges();
                Console.Clear();
                Console.WriteLine("Product list cleared, press any key");
                Console.ReadKey();
                MainView.Display();
                
                
                
            }
        }
    }
}
