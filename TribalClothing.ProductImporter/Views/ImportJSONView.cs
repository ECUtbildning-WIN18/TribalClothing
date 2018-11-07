using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TribalClothing.ProductImporter.Domain.Services;

namespace TribalClothing.ProductImporter.Views
{
    class ImportJSONView
    {
        public void Display()
        {
            var done = false;
            do
            {
                Console.Clear();
                Console.WriteLine(" Please paste the filepath of your json-file");
                Console.Write(" >");
                var jsonFilePath = Console.ReadLine();
                var importJSON = new ImportJSON();
                importJSON._ImportJSON(jsonFilePath);
                Thread.Sleep(2000);
                done = true;

            } while (!done);
        }
    }
}
