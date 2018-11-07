using System.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    internal class ClearProductsFromDb
    {
        public void ClearDb()
        {
            using (var context = new TribalClothingContext())
            {
                var productList = new TribalClothingContext().Products.ToList();

                foreach (var product in productList) context.Remove(product);

                context.SaveChanges();
            }
        }
    }
}