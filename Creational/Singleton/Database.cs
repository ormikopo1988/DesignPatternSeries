using System;

namespace Singleton
{
    /// <summary>
    /// The Database class defines the `GetInstance` method that lets
    /// clients access the same instance of a database connection
    /// throughout the program.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The field for storing the singleton instance should be
        /// declared static.
        /// </summary>
        private static Database instance;

        private static readonly object threadLock = new object();

        /// <summary>
        /// The singleton's constructor should always be private to
        /// prevent direct construction calls with the `new`
        /// operator.
        /// </summary>
        private Database()
        {
            // Some initialization code, such as the actual
            // connection to a database server.
            // ...
        }

        /// <summary>
        /// The static method that controls access to the singleton
        /// instance.
        /// </summary>
        /// <returns></returns>
        public static Database GetInstance()
        {
            if (instance == null)
            {
                lock(threadLock)
                {
                    // Ensure that the instance hasn't yet been
                    // initialized by another thread while this one
                    // has been waiting for the lock's release.
                    if (instance == null)
                    {
                        instance = new Database();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// Finally, any singleton should define some business logic
        /// which can be executed on its instance.
        /// </summary>
        /// <param name="sqlQuery"></param>
        public void ExecuteQuery(string sqlQuery)
        {
            Console.WriteLine($"Executing sql query: {sqlQuery}");
        }
    }
}
