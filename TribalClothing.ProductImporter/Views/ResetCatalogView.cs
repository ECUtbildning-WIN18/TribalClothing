using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
                context.SaveChanges();
                Console.WriteLine("Database has been cleared\n" +
                                  "Press return to go back");
                Console.ReadLine();
            }
        }
    }
}