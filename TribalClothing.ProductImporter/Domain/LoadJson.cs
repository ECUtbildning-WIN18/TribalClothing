using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class LoadJson
    {
        public void ReadJson()
        {
            using (StreamReader r = new StreamReader("Products.json"))
            {

                var json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Product>>(json);
                var lista = new List<Product>();
                foreach (var item in items)
                {
                    var product = new Product();
                    product.Name = item.Name;
                    product.Description = item.Description;
                    product.Price = item.Price;

                    lista.Add(product);
                }

                using (var context = new TribalClothingContext())
                {
                    context.Products.AddRange(lista);
                    var result = context.SaveChanges();
                }
            }
        }
    }
}

