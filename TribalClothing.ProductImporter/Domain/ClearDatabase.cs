using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TribalClothing.ProductImporter.Domain
{
    class ClearDatabase
    {
        public void DeleteItemsInDatabase()
        {
            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Products]");
            }

            Console.WriteLine("Database Cleared!");
            Console.WriteLine("press any key to return");
            Console.ReadKey(true);
        }
    }
}
