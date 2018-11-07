namespace TribalClothing.ProductImporter.Domain
{
    class ProductStorage
    {
        public void StoreProducts()
        {
            using (var context = new TribalClothingContext())
            {
                var product = new Product();

                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
