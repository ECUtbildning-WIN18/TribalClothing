using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TribalClothing.ProductImporter.Domain.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ImportCSVView
    {
        public void Display()
        {
            var done = false;
            do
            {
                Console.Clear();
                Console.WriteLine(" Please paste the filepath of your csv-file");
                Console.Write(" >");
                var csvFilePath = Console.ReadLine();
                var importCSV = new ImportCSV();
                importCSV._ImportCSV(csvFilePath);
                Thread.Sleep(2000);
                done = true;

            } while (!done);
        }
    }
}
