using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TribalClothing.ProductImporter.Domain;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace TribalClothing.ProductImporter.Services
{
    class DataHelper
    {

        public static void ListProducts(List<Product> productList)
        {
            Console.WriteLine($"Total product: {productList.Count}");
            Console.WriteLine($"NAME\tDESCRIPTION\tPRICE\n");
            foreach (var product in productList)
            {
                Console.WriteLine($"{product.Name}\t{product.Description}\t{product.Price}\n");
            }
        }


        public static List<Product> GetProductsFromDb()
        {
            using (var context = new TribalClothingContext())
            {
                var products = context.Products.ToList();
                return products;
            }
        }


        public static void StoreProductsToDb(List<Product> productList)
        {
            using (var context = new TribalClothingContext())
            {
                foreach(var product in productList)
                {
                    var newProduct = new Product(product.Name, product.Description, product.Price);
                    context.Products.Add(newProduct);
                    context.SaveChanges();
                }      
            }   
        }



        public static List<Product> ImportFromJSONFile()
        {
            var productList = new List<Product>();
            using (var reader = new StreamReader("Product.json"))
            {
                var json = reader.ReadToEnd();
                productList = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            return productList;
        }



        public static List<Product> ImportFromCSVFile()
        {
            var products = new List<Product>();
            using (var reader = new StreamReader("Product.csv"))
            {
                var csvReader = new CsvReader(reader);
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    products.Add(new Product(values[1], values[2], Convert.ToDecimal(values[3])));
                }
                return products;
            }
        }


        public static void ClearProductCatalog()
        {
            using (var context = new TribalClothingContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Products]");
                context.SaveChanges();
            }
        }


    }
}
