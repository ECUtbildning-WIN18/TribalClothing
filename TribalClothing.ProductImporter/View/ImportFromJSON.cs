using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace TribalClothing.ProductImporter.Domain
{
    class ImportFromJSON
    {
        public void Display()
        {
            Console.WriteLine("Import from JSON");

            using (StreamReader r = new StreamReader("import.json"))
            {
                string json = r.ReadToEnd();
                List<Product> Products = JsonConvert.DeserializeObject<List<Product>>(json);

                using (var context = new TribalClothingContext())
                {
                    foreach (var item in Products)
                    {
                        var product = new Product(item.Name, item.Description, item.Price);
                        context.Products.Add(product);
                        context.SaveChanges();
                    }
                }

            }

            

        }
    }
}
