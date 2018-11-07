using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    class LoadJson
    {
        public static void ReadJson()
        {
            //"C:\Workspace\ECUtbildning\TribalClothing\TribalClothing.ProductImporter\bin\Debug\products.json"

            using (StreamReader reader = new StreamReader("products.json"))
            {
                var json = reader.ReadToEnd();

                var products = JsonConvert.DeserializeObject<List<Product>>(json);

                using (var db = new TribalClothingContext())
                {
                    foreach (var product in products)
                    {
                        db.Products.Add(product);
                    }
                    db.SaveChanges();
                }
            }

           
        }

    }
}
