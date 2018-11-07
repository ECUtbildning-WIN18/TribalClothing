using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TribalClothing.ProductImporter.Domain
{
    internal class ProductLoaderJson
    {
        public void ImportToDb()
        {
            var filePath = @"C:\Workspace\ECUtbildning\TribalClothing\TribalClothing.ProductImporter\ProductsJSON.JSON";

            using (var reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Product>>(json);

                using (var context = new TribalClothingContext())
                {
                    foreach (var item in items) context.Add(item);

                    context.SaveChanges();
                }
            }
        }
    }
}