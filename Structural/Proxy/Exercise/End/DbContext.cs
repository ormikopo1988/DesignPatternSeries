using System;
using System.Collections.Generic;

namespace Proxy.Exercise.End
{
    public class DbContext
    {
        private readonly Dictionary<int, Product> updatedObjects = new Dictionary<int, Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine($"SELECT * FROM products WHERE product_id = {id}");

            var product = new ProductProxy(id, this);
            product.Name = "Product 1";

            return product;
        }

        public void SaveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in updatedObjects.Values)
            {
                Console.WriteLine($"UPDATE products SET name = '{updatedObject.Name}' WHERE product_id = {updatedObject.Id}");
            }

            updatedObjects.Clear();
        }

        public void MarkAsChanged(Product product)
        {
            updatedObjects[product.Id] = product;
        }
    }
}
