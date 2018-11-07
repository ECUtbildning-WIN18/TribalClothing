using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        static void ImportCsv()
        {
            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();
            }
        }

        public void storeProductCsv()
        {
            using (var context = new TribalClothingContext())
            {
                //var product = new Product("Peruvian 1", "Lorum ipsum", 100);

                //context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateCsv()
        {
            using (var context = new TribalClothingContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Id == 1);

                if (product != null)
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
        }
    }
}
