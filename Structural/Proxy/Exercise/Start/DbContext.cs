using System;
using System.Collections.Generic;

namespace Proxy.Exercise.Start
{
    /// <summary>
    /// We’re going to build an O/RM (Object Relational Mapper). 
    /// ORMs are tools responsible for mapping data between a relational database and an object-oriented model. 
    /// There are many popular O/RMs out there such as Hibernate, Entity Framework and Dapper. 
    /// You can see a “super simplified” implementation of our imaginary ORM in the current class. 
    /// We use the DbContext class to read or write data to our database. 
    /// A typical workflow for using a DbContext:
    ///     - Read an object from a database (dbContext.GetProduct()) 
    ///     - Change the properties of the in-memory object (product.Name = "...") 
    ///     - Ask the dbContext to save the changes (dbContext.SaveChanges()) 
    /// If you try to run the code in the Program class for the Start section of the exercise, you’ll only see a SELECT statement printed on the terminal. 
    /// This simulates reading a product record from a database. 
    /// What is missing is the two UPDATE statements that should be generated when we save the changes. 
    /// The reason this is happening is that our DbContext cannot keep track of the changed objects. 
    /// So, when we call SaveChanges(), nothing happens. 
    /// We can solve this problem using the proxy pattern. 
    /// A proxy object looks like our target object (eg a Product object) but it adds some extra behavior to it. 
    /// For example, when we call the .Name setter method, the proxy notifies the DbContext that it is changed. 
    /// DbContext provides a method for this: MarkAsChanged(). 
    /// Use the proxy pattern to allow DbContext to keep track of changed objects and persist them in a database.
    /// NOTE: Some real-world O/RMs automatically generate these proxy objects based for you, so you don’t need to code them by hand.
    /// </summary>
    public class DbContext
    {
        private readonly Dictionary<int, Product> updatedObjects = new Dictionary<int, Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine($"SELECT * FROM products WHERE product_id = {id}");

            // Simulate reading a product object from a database.
            var product = new Product(id);
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
