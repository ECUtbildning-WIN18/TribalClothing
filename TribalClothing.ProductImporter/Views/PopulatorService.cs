namespace TribalClothing.ProductImporter.Views
{
    public struct PopulatorService
    {

        private static readonly string[] MainMenu =
        {
            "1. List Products",
            "2. Import from CSV",
            "3. Import from JSON",
            "4. Clear product from catalog",
            "ESC: Exit"
        };
        
        public string[] MenuPopulator(int index)
        {
            switch (index)
            {
                case 1: return MainMenu;
                default: return null;
            }
        }
    }
}