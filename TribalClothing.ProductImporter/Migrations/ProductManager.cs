﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.Migrations
{
    class ProductManager
    {
        TribalClothingContext db = new TribalClothingContext();
        List<Product> products;             
        public void ListProducts()
        {
            List<Product> pl = db.Products.ToList();
            foreach (var item in pl)
            {
                Console.WriteLine(item.Id + ", " + item.Name + ", " + item.Description + ", " + item.Price);
            }
        }

        public void DeleteProducts()
        {
            db.Database.ExecuteSqlCommand("Truncate table products");
        }

        public void ImportJson()
        {
            using (StreamReader r = new StreamReader("products-json.json"))
            {
                string json = r.ReadToEnd();
                products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
                db.Products.Add( new Product { Name = item.Name, Description = item.Description, Price = item.Price } );
            }
            db.SaveChanges();
            //db.Dispose();
        }

        public void ImportCsv()
        {
            List<string> lines = new List<string>();
            using (var reader = new StreamReader("products-csv.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    lines.Add(line);
                }
                //var csvReader = new CsvReader(reader);
                //var records = csvReader.GetRecords<Product>();
                for (int i = 1; i<lines.Count; i++)
                {
                    var values = lines[i].Split(";");
                    db.Products.Add(new Product { Name = values[1], Description = values[2], Price = decimal.Parse(values[3]) });
                }
            }
            
            db.SaveChanges();
            //db.Dispose();
        }
    }
}
