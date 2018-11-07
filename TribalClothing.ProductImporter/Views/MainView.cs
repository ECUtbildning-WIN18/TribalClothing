using System;
using System.Collections.Generic;
using System.Text;

namespace TribalClothing.ProductImporter.Views
{
    class MainView
    {

        public void StartView()
        {

            bool menu = true;

            while (menu)
            {
                Console.WriteLine("1. List products");
                Console.WriteLine("2. Import from CSV");
                Console.WriteLine("3. Import from JSON");
                Console.WriteLine("4. Clear product catalog");

                string menuChoise = Console.ReadLine();


                switch (menuChoise)
                {
                    case "1":
                        {
                            break;
                        }
                    case "2":
                        {
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    case "4":
                        {
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

            }

        }

    }
}
