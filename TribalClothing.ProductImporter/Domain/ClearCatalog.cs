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
            RemoveAllProducts();
        }
        static void RemoveAllProducts()
        {

            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            }
            
        }
        
    }
}
