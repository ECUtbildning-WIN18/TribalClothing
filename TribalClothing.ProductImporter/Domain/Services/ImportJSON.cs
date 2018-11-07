using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace TribalClothing.ProductImporter.Domain.Services
{
    class ImportJSON
    {
        public void _ImportJSON(string json_filepath)
        {
            using (var context = new TribalClothingContext())
            {
                //csv = new Product("Peruvian 1", "Lorum ipsum", 100);

                using (var r = new StreamReader(json_filepath))
                {
                    var json = r.ReadToEnd();
                    var jobjs = JObject.Parse(json);

                    foreach (var jobj in jobjs.Properties())
                    {
                        context.Products.Add(jobj.ToObject<Product>());
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
