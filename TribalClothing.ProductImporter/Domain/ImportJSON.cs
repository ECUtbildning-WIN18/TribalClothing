using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TribalClothing.ProductImporter.Domain
{

    class ImportJSON
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("# Import from JSON");

            using (var context = new TribalClothingContext())
            {
                using (StreamReader reader = new StreamReader("Product.json"))
                {

                    var json = reader.ReadToEnd();

                    var products = JsonConvert.DeserializeObject<List<Product>>(json);

                    //foreach (var prod in products)
                    //{
                    //    Console.WriteLine($"Name: {prod.Name} Description: {prod.Description} Price: {prod.Price} ID: {prod.Id}");
                    //}
                
                   context.Products.AddRange(products);
                   context.SaveChanges();
                }
                
            }

            Console.ReadKey();

        }

    }
}
