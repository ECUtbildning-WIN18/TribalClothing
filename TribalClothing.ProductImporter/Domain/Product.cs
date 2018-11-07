﻿
using System.Runtime.Serialization;

namespace TribalClothing.ProductImporter.Domain
{
    class Product
    {
        [IgnoreDataMember]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }


}
