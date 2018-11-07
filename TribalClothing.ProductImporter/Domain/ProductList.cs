using System.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    class ProductList
    {
        public void ListProducts()
        {
            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();
            }
        }
    }
}
