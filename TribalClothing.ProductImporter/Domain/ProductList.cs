using System;
using System.Linq;

namespace TribalClothing.ProductImporter.Domain
{
    class ProductList
    {
        public void Display()
        {
            Console.Clear();

            Console.WriteLine("# List products: ");

            using (var context = new TribalClothingContext())
            {
                int count = 0;

                var products = context.Products.ToList();
                
                foreach (var product in products)
                {
                    
                    Console.WriteLine($"Name: {product.Name} Id: {product.Id}  Price: {product.Price} Description: {product.Description}");
                    count++;
                }

                Console.WriteLine($"\n Total products: {count}");
                Console.WriteLine("\nEnd of List \r press any button to continue.");
                Console.ReadKey();

                var menu = new MenuView();
                menu.Display();
            }
        }
    }
}
