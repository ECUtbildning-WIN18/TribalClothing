using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class PrintUser
    {
        public List<Product> GetUsers()
        {
            var products = new List<Product>();

            using (var context = new TribalClothingContext())
            {
                var product = context.Products.ToList();
                
                return product;
            }
        }
    }
}
