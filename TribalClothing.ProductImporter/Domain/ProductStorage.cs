namespace TribalClothing.ProductImporter.Domain
{
    class ProductStorage
    {
        public void StoreProducts()
        {
            using (var context = new TribalClothingContext())
            {
<<<<<<< HEAD
                var product = new Product(1, "Lorum ipsum", "Shirt", 100);
=======
                var product = new Product();
>>>>>>> 701144283a5589ba1475e3b52e08292b5588b61d

                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
