using System;

namespace TribalClothing.ProductImporter.Views
{
    abstract class BaseView
    {        
        protected internal BaseView(string title) //View without a set menu
        {
            Console.Title = title;
        }
        
        protected internal BaseView(string title, int menuChoice) //View with a set menu
        {
            Console.Title = title;
            var entries = new PopulatorService().MenuPopulator(menuChoice);
            DrawEntries(entries);
        }

        private void DrawEntries(string[] entries)
        {
            foreach (var s in entries)
            {
                Console.WriteLine(s);
            }
        }
    }
}