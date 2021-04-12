using System;

namespace Singleton
{
    /// <summary>
    /// Singleton is a creational design pattern that lets you ensure
    /// that a class has only one instance, while providing a global
    /// access point to this instance.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var databaseOne = Database.GetInstance();

            databaseOne.ExecuteQuery("SELECT * FROM Product");

            var databaseTwo = Database.GetInstance();

            databaseTwo.ExecuteQuery("SELECT * FROM User");

            // The variable `databaseOne` will contain the same object as
            // the variable `databaseTwo`.
            Console.WriteLine(databaseOne == databaseTwo);

            Console.ReadLine();
        }
    }
}
