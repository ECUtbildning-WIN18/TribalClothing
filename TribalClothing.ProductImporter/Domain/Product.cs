
using System.Runtime.Serialization;
using CsvHelper.Configuration.Attributes;

namespace TribalClothing.ProductImporter.Domain
{
    class Product
    {
        
        [IgnoreDataMember] public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
