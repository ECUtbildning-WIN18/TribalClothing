using System;
using System.Collections.Generic;
using System.Text;
using TribalClothing.ProductImporter.Domain;

namespace TribalClothing.ProductImporter.Views
{
    class ImportJsonView
    {
        
        public void Display()
        {
            var db = new Database();
            
            Console.Clear();
            Console.WriteLine("Do you want to add the JSON information to database?");
            Console.WriteLine("(Y)es / (N)o");
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                var jsonList = ImportJSON.FromFile();
                db.AddData(jsonList);
            }
        }
    }
}
