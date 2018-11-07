using System;
using System.Linq;

namespace TribalClothing.ProductImporter.View
{
    class ListProductView
    {
        public void Display()
        {
            int count = 0;
            
            Console.Clear();
            Console.WriteLine("Total products:");
            Console.WriteLine("\nPRODUCT NAME               PRODUCT DESCRIPTION");

            using (var db = new TribalClothingContext())
            {
                var productList = db.Products.ToList();

                foreach (var product in productList)
                {
                    Console.WriteLine($"{product.Name}                   {product.Description}");
                    count += 1;
                }
            }

            WriteAt($"{count}", 16 ,0);
            Console.ReadKey();

            MainMenuView.Display();
        }

        public static int xCoord, yCoord, y;

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
