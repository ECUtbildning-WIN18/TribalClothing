using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter.Services
{
    class ClearList
    {
        public void RemoveProducts()
        {
            Console.Clear();

            using (var db = new TribalClothingContext())
            {
                var productList = db.Products.ToList();

                foreach (var product in productList)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                }

                Console.WriteLine("\nList cleared!");
                Thread.Sleep(2000);
                MainMenuView.Display();
            }
        }
    }
}
