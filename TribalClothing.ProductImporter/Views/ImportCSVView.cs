using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using TribalClothing.ProductImporter.Domain;
using TribalClothing.ProductImporter.Views.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ImportCSVView : BaseView
    {
        public ImportCSVView() : base("Import from CSV file")
        {
            
        }

        public void Run()
        {
            var itemsToAdd = ParseCSV();
            using (var context = new TribalClothingContext())
            {
                context.Products.AddRange(itemsToAdd);
                context.SaveChanges();
            }

            Console.WriteLine("Items from CSV file added to the database!\n" +
                              "Press return to go back");
            Console.ReadLine();
        }

        private IEnumerable<Product> ParseCSV()
        {
            var reader = new StreamReader(@"items.csv");
            var csvReader = new CsvReader(reader);
            csvReader.Configuration.RegisterClassMap<CSVMapper>();
            csvReader.Configuration.Delimiter = ";";
            return csvReader.GetRecords<Product>();
        }
    }
}