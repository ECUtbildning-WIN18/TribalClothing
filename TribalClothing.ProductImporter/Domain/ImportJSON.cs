using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TribalClothing.ProductImporter.Domain;

class ImportJSON
{
    public static IList<Product> FromFile()
    {
        using (StreamReader reader = new StreamReader("ProductList.json"))
        {
            var json = reader.ReadToEnd();
            var ProductList = JsonConvert.DeserializeObject<List<Product>>(json);

            return ProductList;
        }
    }
}