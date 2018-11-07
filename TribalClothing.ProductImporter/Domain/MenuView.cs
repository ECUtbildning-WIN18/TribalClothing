using System;
using System.Collections.Generic;
using System.Text;

namespace TribalClothing.ProductImporter.Domain
{
    class MenuView
    {

        public string Display()
        {
            Console.Clear();
            Console.WriteLine("1. List products");
            Console.WriteLine("2. Import from CSV");
            Console.WriteLine("3. Import from JSON");
            Console.WriteLine("4. Clear product catalog");

            var consoleKeyInfo = Console.ReadKey(true);

            bool runMenu = true;

            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                {
                    var List = new ProductList();
                    List.Display();
                    return "1";

                }
                   

                case ConsoleKey.D2:
                {
                    var csv = new ImportCSV();
                    csv.Display();
                    return "2";
                }
                        

                case ConsoleKey.D3:
                {
                    var json = new ImportJSON();
                    json.Display();
                    return "3";
                }
                       

                case ConsoleKey.D4:
                {
                    var clear = new ClearCatalog();
                    clear.Display();
                    return "4";
                }
                       

                default:
                    var menu = new MenuView();
                    menu.Display();

                    break;
            }

            return "";
        }

    }
}
