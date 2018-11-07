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
            Console.WriteLine("# Clear product catalog");

            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            }
        }
    }
}
