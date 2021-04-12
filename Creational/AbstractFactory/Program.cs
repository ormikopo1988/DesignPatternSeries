using System;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract Factory is a creational design pattern that lets you
    /// produce families of related objects without specifying their
    /// concrete classes.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The application picks the factory type depending on the
        /// current configuration or environment settings and creates it
        /// at runtime (usually at the initialization stage).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var factory = Initialize("Windows");
            //var factory = Initialize("Mac");

            var application = new Application(factory);

            application.CreateUI();
            application.Paint();

            Console.ReadLine();
        }

        static IGUIFactory Initialize(string os)
        {
            if (os == "Windows")
            {
                return new WindowsFactory();
            }
            else if (os == "Mac")
            {
                return new MacFactory();
            }
            else
            {
                throw new ArgumentException("Unknown OS value.");
            }
        }
    }
}
