using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class ImportJSON
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("# Import from JSON");
            
        }
        static void ImportCsv()
        {
            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();
            }
        }

        public void storeProductCsv()
        {
            using (var context = new TribalClothingContext())
            {
                //var product = new Product("Peruvian 1", "Lorum ipsum", 100);

                //context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateCsv()
        {
            using (var context = new TribalClothingContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Id == 1);

                if (product != null)
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
        }
    }
}
