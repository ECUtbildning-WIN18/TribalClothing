using System;
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
                Console.Write("\n >");

                var jsonFilePath = Console.ReadLine();
                var importJSON = new ImportJSON();
                importJSON._ImportJSON(jsonFilePath);

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
