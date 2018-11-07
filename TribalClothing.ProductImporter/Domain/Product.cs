﻿
using Newtonsoft.Json;

namespace TribalClothing.ProductImporter.Domain
{
    class Product
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            
        }
        
        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
