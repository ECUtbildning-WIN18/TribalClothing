<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.Views
=======
﻿namespace TribalClothing.ProductImporter.Views
>>>>>>> ca98bee53f681d4fe37554e07fa593d26dc5e2b6
{
     class ImportCsvView
    {
        public List<Product> productList = new List<Product>();

        public void Display()
        {
            var lines = File.ReadAllLines("TribalClothingCsv.csv");

            foreach (var product in lines)
            {
                var values = product.Split(';');


                Product newProduct = new Product();
                newProduct.Name = values[0];
                newProduct.Description = values[1];
                newProduct.Price = decimal.Parse(values[2]);
                productList.Add(newProduct);

                //productList.Add(new Product()
                //{
                //    Name = values[0],
                //    Description = values[2],
                //    Price = decimal.Parse(values[3])
                //});

                Console.WriteLine(newProduct.Name, newProduct.Description, newProduct.Price);
            } 
        }
    }
}



