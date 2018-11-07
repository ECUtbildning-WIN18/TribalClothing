using System.Collections.Generic;

namespace TribalClothing.ProductImporter.Domain
{
    public class Database
    {
        public void AddData(IList<Product> ProductList)
        {
            using (var context = new TribalClothingContext())
            {
                    foreach (var product in ProductList)
                    {
                        context.Products.Add(product);
                    }
                    context.SaveChanges();
            }
        }
    }
}