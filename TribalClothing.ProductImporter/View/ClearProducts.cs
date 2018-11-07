using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TribalClothing.ProductImporter.View
{
    class ClearProducts
    {
        public void RemoveAllProducts()
        {
            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            }
        }

    }
}
