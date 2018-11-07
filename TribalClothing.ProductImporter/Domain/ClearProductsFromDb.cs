using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class ClearProductsFromDb
    {
        public void ClearDb()
        {
            using (var context = new TribalClothingContext())
            {
                var productList = new TribalClothingContext().Products.ToList();

                foreach (var product in productList)
                {
                    context.Remove(product);
                }

                context.SaveChanges();
            }
        }
    }
}
