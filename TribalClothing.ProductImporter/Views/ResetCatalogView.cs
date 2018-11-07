using System;
using System.Collections.Generic;
using System.Linq;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Views.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ResetCatalogView : BaseView
    {
        public ResetCatalogView() : base("Reset Catalog View")
        {
            
        }

        public void Run()
        {
            using (var context = new TribalClothingContext())
            {
                if (context.Products.Count() < 1)
                {
                    foreach (var p in context.Products)
                    {
                        context.Products.Remove(p);
                    }

                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Nothing exists in the database to be cleared\n" +
                                      "Press return to go back");
                    Console.ReadLine();
                }
            }
        }
    }
}