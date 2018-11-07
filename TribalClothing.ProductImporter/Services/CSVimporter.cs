using System;
using System.IO;

namespace TribalClothing.ProductImporter.Services
{
    class CSVimporter
    {
        public static void import()
        {
            using (var reader = new StreamReader("Products.csv"))
            {
                {
                    var line = reader.ReadLine();

                    var values = line.Split(';');

                    var id = Convert.ToInt32(values[0]);
                    var name = values[1];
                    var description = values[2];
                    var price = Convert.ToDecimal(values[3]);



                    //using (var context = new TribalClothingContext())
                    //{

                    //    var product = new Product(id, name, description, price);
                    //    foreach (var VARIABLE in context)
                    //    {
                    //        V
                    //    }
                    //    context.Products.Add(product);
                    //    context.SaveChanges();
                    //}



                }


            }
        }
    }
}
