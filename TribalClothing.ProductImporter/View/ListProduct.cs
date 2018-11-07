using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TribalClothing.ProductImporter.View
{
    class ListProduct
    {
        public void Display()
        {
            // US02: As a user I want to be able to list all current products in the product catalog so that I can see what’s been imported
            Console.WriteLine("List Product");

            // skapa lista som visar importerad information från databasen - JSON och CSV
            string connectionString = "Data Source=(local);Initial Catalog=TribalClothing;Integrated Security=true";

            string queryString = $"SELECT Products VALUES('{name}', '{description}', '{price}')";

            using (var connection = new SqlConnection(connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                connection.Open();

                var reader = sqlCommand.ExecuteNonQuery();
                
            }
        }
    }
}
