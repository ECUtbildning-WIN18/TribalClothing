using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;

namespace TribalClothing.ProductImporter.Domain
{
   sealed class ProductMapper : ClassMap<Product>
    {
        public ProductMapper()
        {
            Map(m => m.Name);
            Map(m => m.Description);
            Map(m => m.Price);
        }
    }
}
