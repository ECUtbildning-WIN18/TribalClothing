using TribalClothing.ProductImporter.Domain.View;

namespace TribalClothing.ProductImporter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var startMenu = new StartMenu();
            startMenu.Display();
        }
    }
}