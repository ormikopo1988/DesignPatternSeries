using System;

namespace FactoryMethod
{
    /// <summary>
    /// Also known as: Virtual Constructor
    /// Factory Method is a creational design pattern that provides
    /// an interface for creating objects in a superclass, but allows
    /// subclasses to alter the type of objects that will be created.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // The application picks a creator's type depending on the
            // current configuration or environment settings.
            var dialog = Initialize("Web");
            //var dialog = Initialize("Windows");

            // The client code works with an instance of a concrete
            // creator through its base interface. As long as
            // the client keeps working with the creator via the base
            // interface, you can pass it any creator's subclass.
            dialog.Render(2, 3);

            Console.ReadLine();
        }

        static Dialog Initialize(string os)
        {
            if (os == "Windows")
            {
                return new WindowsDialog();
            }
            else if (os == "Web")
            {
                return new WebDialog();
            }
            else
            {
                throw new ArgumentException("Unknown OS value.");
            }
        }
    }
}
