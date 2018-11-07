﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TribalClothing.ProductImporter.View;

namespace TribalClothing.ProductImporter.Domain
{
    class LoadJson
    {
        public static void ReadJson()
        {
            //"C:\Workspace\ECUtbildning\TribalClothing\TribalClothing.ProductImporter\bin\Debug\products.json"

            using (StreamReader reader = new StreamReader("Products.json"))
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
                    Console.Clear();
                    Console.WriteLine("Products imported, press any key");
                    Console.ReadKey();
                    MainView.Display();

                    
                }
            }

           
        }

    }
}
