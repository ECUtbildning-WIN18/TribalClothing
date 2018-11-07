using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;

namespace TribalClothing.ProductImporter.Domain.Services
{
    class ImportCSV
    {
        public void _ImportCSV(string csv_filepath)
        {
            using (var context = new TribalClothingContext())
            {

                TextReader reader = new StreamReader(csv_filepath);
                var csvReader = new CsvReader(reader);
                var records = csvReader.GetRecords<Product>();

                context.Products.Add(new Product());
                context.SaveChanges();
            }
        }
    }
}
