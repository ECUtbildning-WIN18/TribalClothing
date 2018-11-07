using System;
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
                Console.Write("\n >");

                var csvFilePath = Console.ReadLine();
                var importCSV = new ImportCSV();
                importCSV._ImportCSV(csvFilePath);

                Console.Write("Importing.");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                done = true;
            } while (!done);
        }
    }
}
