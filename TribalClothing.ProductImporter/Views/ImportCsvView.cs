using System;
using System.Collections.Generic;
using System.IO;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.Views
{ 
     class ImportCsvView
    {
        public List<Product> productList = new List<Product>();

        public void Display()
        {
            Console.Clear();

            var lines = File.ReadAllLines("TribalClothingCsv.csv");

            foreach (var product in lines)
            {
                var values = product.Split(';');


                Product newProduct = new Product();
                newProduct.Name = values[1];
                newProduct.Description = values[2];
                newProduct.Price = decimal.Parse(values[3]);
                productList.Add(newProduct);

                Console.ReadKey();
            }

            foreach (var element in productList)
            {
                Console.WriteLine($"{element.Name}, {element.Description}, {element.Price}");
            }

            var database = new Database();
            database.AddData(productList);
        }
    }
}



