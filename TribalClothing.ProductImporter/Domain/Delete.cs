using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class Delete
    {
        public void DeleteUser(List<Product> products)
        {
            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");

                //if (products == null) return;

                //context.Products.RemoveRange(products);
                //context.SaveChanges();
            }
        }
    }
}
