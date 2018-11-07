using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class ImportFromJSON
    {
        public void ImportJSON()
        {
            using (var context = new TribalClothingContext())
            {
                var product = new Product("Peruvian 1", "Lorum ipsum", 100);

                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
