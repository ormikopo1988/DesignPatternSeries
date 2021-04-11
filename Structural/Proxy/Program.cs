using System;

namespace Proxy
{
    /// <summary>
    /// Proxy is a structural design pattern that lets you provide a
    /// substitute or placeholder for another object. A proxy controls
    /// access to the original object, allowing you to perform
    /// something either before or after the request gets through to
    /// the original object (operations like logging, lazy loading, authorization, etc.).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var fileNames = new string[] { "a", "b", "c" }; // Suppose these come from the database

            Console.WriteLine("- Problem -");

            // With this implementation, currently we have three ebooks in our library. 
            // What if we have hundres or thousands of ebooks? When our application loads,
            // we have to load all these ebooks from the disk (database or file system)
            // into the memory. The user, however, is not going to open every single ebook
            // that is loaded in memory. In this demo, the user is only interested in ebook "a"
            // but we are also loading all other ebooks in memory. This is where we can use
            // the proxy pattern. As we can see from this example, creating an ebook object
            // is a little bit costly, because we have to read it from the disk and store it
            // in memory. With the proxy pattern, we can create an object that simulates a real
            // ebook, but it is going to load this ebook on demand, only when we really need it.
            var library = new Problem.Library();
            foreach (var fileName in fileNames)
            {
                library.Add(new Problem.Ebook(fileName));
            }
            library.OpenEbook("a");

            Console.WriteLine("- Solution -");

            var libraryUsingProxy = new Solution.Library();
            foreach (var fileName in fileNames)
            {
                libraryUsingProxy.Add(new Solution.EbookProxy(fileName));
                //libraryUsingProxy.Add(new Solution.AuthorizationEbookProxy(fileName));
            }
            libraryUsingProxy.OpenEbook("a");

            Console.WriteLine("--- Exercise ---");

            Console.WriteLine("- Start -");

            var dbContextStart = new Exercise.Start.DbContext();

            // We read an object (eg a product) from a database.
            var product = dbContextStart.GetProduct(1);

            // We modify the properties of the object in memory.
            product.Name = "Updated Name";

            // DbContext should keep track of changed objects in memory.
            // When we call SaveChanges(), it'll automatically generate
            // the right SQL statements to update our database.
            dbContextStart.SaveChanges();

            // After saving the changes to the database, we can
            // change our in-memory object again and save the changes.
            product.Name = "Another name";
            dbContextStart.SaveChanges();

            Console.WriteLine("- End -");

            var dbContextEnd = new Exercise.End.DbContext();
            var anotherProduct = dbContextEnd.GetProduct(1);
            anotherProduct.Name = "Updated Name";
            dbContextEnd.SaveChanges();

            anotherProduct.Name = "Another name";
            dbContextEnd.SaveChanges();

            Console.ReadLine();
        }
    }
}
