using System;
using System.Collections.Generic;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class MainMenu
    {
        public void Display() { 
        Console.Title = "Main Menu";

            bool LoopisFinished = false;
            while (LoopisFinished == false) // Stop loop to go back to Main
            {
                Console.Clear(); 
                Console.WriteLine("== Main Menu ==");
                Console.WriteLine("\n1. List Products" +
                                  "\n2. Import from CSV" + 
                                  " \n3. Import from JSON" +
                                  "\n4. Clear Product Catalog" +
                                  "\n5. Exit Application");
                Console.Write("\nSelect Action:");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1: // list
                    
                    break;

                    case ConsoleKey.D2: // Import CSV
                        CSVLoader CSVProducts = new CSVLoader();
                        CSVProducts.LoadFromCSV();
                    break;

                    case ConsoleKey.D3: // Import JSON
                    break;
                    case ConsoleKey.D4: // Clear Products
                        LoopisFinished = true;
                        break;
                    case ConsoleKey.D5: // Log Out
                        Environment.Exit(0);
                        break;

                    default:
                    Console.WriteLine("Selection Error");
                    break;
                }
            }

        }
    }
 }

