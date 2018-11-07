using System.Linq;

namespace TribalClothing.ProductImporter.View
{
    class ListView
    {
        public static void Diaplay()
        {
            using (var context = new TribalClothingContext())
            {
                var productList = context.Products.ToList();

                foreach (var productList in list)
                {

                }

            }
        }
    }
}
