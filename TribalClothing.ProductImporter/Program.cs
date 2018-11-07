using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("1. List products");
            Console.WriteLine("2. Import from CSV");
            Console.WriteLine("3. Import from JSON");
            Console.WriteLine("4. Clear product catalog");
            Console.WriteLine("5. Clear duplicates from catalog");
            var choice =Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    using (var db = new TribalClothingContext())
                    {
                        foreach (var product in db.Products)
                        {
                            Console.WriteLine(product.Name);
                        }
                    }
                    break;
                case "2":
                    ListOfProductsToDb(LoadCsv());
                    break;
                case "3":
                    ListOfProductsToDb(LoadJson());
                    break;
                case "4":
                    using (var db = new TribalClothingContext())
                    {
                        foreach (var product in db.Products)
                        {
                            db.Products.Remove(product);
                        }

                        db.SaveChanges();
                    }
                    break; 
                case "5":
                    RemoveDuplicates();
                    break;
                default:
                    Menu();
                    break;
            }
            Menu();
        }
        
        private static IEnumerable<Product> LoadJson()
        {
            using (var r = new StreamReader("Domain/Products.json"))
            {
                var json = r.ReadToEnd();
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                return products;
            }
        }

        private static void ListOfProductsToDb(IEnumerable<Product> products)
        {
            using (var db = new TribalClothingContext())
            {
                foreach (var product in products)
                {
                    db.Products.Add(new Product(product.Name, product.Description, product.Price));
                }
               
                db.SaveChanges();
            }
        }

        private static void RemoveDuplicates()
        {
            using (var db = new TribalClothingContext())
            {
                var existing = new List<Product>();
                foreach (var product in db.Products)
                {
                    if(existing.Count==0) existing.Add(product);
                    else
                    {
                        if (Duplicate(product, existing)) db.Products.Remove(product);
                        else existing.Add(product);
                    }
                }
                db.SaveChanges();
            }
        }

        private static bool Duplicate(Product product, IEnumerable<Product> existing)
        {
            foreach (var item in existing)
            {
                if (product.Name == item.Name)   return true;
            }
            return false;
        }

        private static List<Product> LoadCsv()
        {
            var products = new List<Product>();
            using(var reader = new StreamReader("Domain/Products.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null&&line!="Id;Name;Description;Price")
                    {
                        var values = line.Split(';');
                        products.Add(new Product(values[1],values[2],decimal.Parse(values[3])));
                    }
                }
            }
            return products;
        }
    }
}

