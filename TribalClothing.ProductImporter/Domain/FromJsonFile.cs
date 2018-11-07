using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    class FromJsonFile
    {
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("ProductList.json"))
            {
                var json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var item in items)
                {
                    using (var context = new TribalClothingContext())
                    {
                        var product = new Product(item.Name, item.Description, item.Price);

                        context.Products.Add(product);
                        context.SaveChanges();
                    }
                }
            }

            Console.WriteLine("\nLoaded from json to database");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}

