using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace TribalClothing.ProductImporter.Domain.Services
{
    class ImportJSON
    {
        public void _ImportJSON(string json_filepath)
        {
            using (var context = new TribalClothingContext())
            {
                using (StreamReader r = new StreamReader(json_filepath))
                {
                    var json = r.ReadToEnd();
                    var jsonConv = JsonConvert.DeserializeObject<List<Product>>(json);
                    foreach (var item in jsonConv)
                    {
                        context.Products.Add(item);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}