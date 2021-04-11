using Iterator.Exercise.End;
using Iterator.Solution;
using System;

namespace Iterator
{
    /// <summary>
    /// Iterator is a behavioral design pattern that lets you traverse
    /// elements of a collection without exposing its underlying
    /// representation(list, stack, tree, etc.)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var browseHistory = new BrowseHistory<string>();
            browseHistory.Push("a");
            browseHistory.Push("b");
            browseHistory.Push("c");

            var browseHistoryIterator = browseHistory.CreateIterator();

            while(browseHistoryIterator.HasNext())
            {
                Console.WriteLine(browseHistoryIterator.Current());

                browseHistoryIterator.Next();
            }

            Console.WriteLine("--- Exercise ---");

            var productCollection = new ProductCollection();
            productCollection.Add(new Product(1, "Product 1"));
            productCollection.Add(new Product(2, "Product 2"));
            productCollection.Add(new Product(3, "Product 3"));

            var productIterator = productCollection.CreateIterator();

            while (productIterator.HasNext())
            {
                Console.WriteLine(productIterator.Current());

                productIterator.Next();
            }

            Console.ReadLine();
        }
    }
}
