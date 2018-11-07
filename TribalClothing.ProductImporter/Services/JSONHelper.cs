using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter.Services
{
    class JSONHelper
    {
        public void GetProduct()
        {
            {
                using (StreamReader r = new StreamReader("Product.json"))
                {
                    var json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<Product>>(json);

                    using (var db = new TribalClothingContext())
                    {
                        foreach (var item in items)
                        {
                            db.Products.Add(item);
                        }

                        db.SaveChanges();

                        Console.Clear();
                        Console.WriteLine("\nImport Success!");
                        Thread.Sleep(2000);

                        MainMenuView.Display();
                    }
                }
            }
        }
    }
}
