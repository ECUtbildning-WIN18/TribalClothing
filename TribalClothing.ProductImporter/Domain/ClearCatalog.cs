using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TribalClothing.ProductImporter.Domain
{
    class ClearCatalog
    {
        public void Display()
        {

            Console.Clear();
            Console.WriteLine("# Clear Catalog ");

            RemoveAllProducts();
        }
        static void RemoveAllProducts()
        {
            using (var context = new TribalClothingContext())
            {

                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");

            }

            Console.WriteLine("Records deleted ! press any button to continue");
            Console.ReadKey();

            var menu = new MenuView();
            menu.Display();
        }
    }
}
