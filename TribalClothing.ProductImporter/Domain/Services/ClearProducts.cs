using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TribalClothing.ProductImporter.Domain.Services
{
    class ClearProducts
    {
        public void _ClearProducts()
        {
            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            }
        }
    }
}
