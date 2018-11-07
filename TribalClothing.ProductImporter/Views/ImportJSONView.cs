using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Views.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ImportJSONView : BaseView
    {
        public ImportJSONView() : base("Import from JSON file")
        {
            
        }

        public void Run()
        {
            IList<Product> itemsToAdd = ParseJson();
            using (var context = new TribalClothingContext())
            {
                foreach (var p in itemsToAdd)
                {
                    context.Products.Add(p);
                }
                context.SaveChanges();
            }

            Console.WriteLine("Items from JSON file added to the database!\n" +
                              "Press return to go back");
            Console.ReadLine();
        }

        private IList<Product> ParseJson()
        {
            using (StreamReader r = new StreamReader(@"Items.JSON"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
        }
    }
}