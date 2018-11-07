using System;
using Microsoft.EntityFrameworkCore.Storage;
using Database = TribalClothing.ProductImporter.Domain.Database;

namespace TribalClothing.ProductImporter.Views
{
    public class ResetView
    {
        public void Display()
        {
            var database = new Database();
            
            Console.Clear();
            Console.WriteLine("Are you sure that you want to delete all data??");
            Console.WriteLine("(Y)es / (N)o");
            var key = Console.ReadKey().Key ;

            if (key == ConsoleKey.Y)
            {
                database.ResetDatabase();
                Console.WriteLine("Database have been reset!");
            }
        }
    }
}