using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TribalClothing.ProductImporter.Migrations;

namespace TribalClothing.ProductImporter
{
    class MainMenu
    {
        public void Display()
        {
            TribalClothingContext db = new TribalClothingContext();
            ProductManager pm = new ProductManager();
            string response;
            while (true)
            {
                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");
                Console.WriteLine("´*`´*`´*`´*`´*`´*`´*`´*`´*`´*`´*`´*`´*`´*`");
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Console.WriteLine("List");
                        pm.listProducts();
                        break;
                    case "2":
                        Console.WriteLine("Import CSV");
                        pm.importCsv();
                        break;
                    case "3":
                        Console.WriteLine("Import JSON");
                        pm.importJson();
                        break;
                    case "4":
                        Console.WriteLine("Clear catalog");
                        pm.deleteProducts();
                        break;
                    default:
                        Console.WriteLine("Chose between 1 and 4 please:");
                        break;
                }
            }
        }
    }
}
