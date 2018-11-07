using System.Collections.Generic;
using System.Linq;

namespace TribalClothing.ProductImporter.Domain.Services
{
    class ListProducts
    {
        public List<Product> _ListProducts()
        {
            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();
                return products;
            }
        }
    }
}
