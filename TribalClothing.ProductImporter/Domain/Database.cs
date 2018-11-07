using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public IList<Product> GetDataList()
        {
            List<Product> products;
            using (var context = new TribalClothingContext())
            {
                products = context.Products.ToList();
            }

            return products;
        }

        public static void ResetDatabase()
        {
            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            }
        }
    }
}