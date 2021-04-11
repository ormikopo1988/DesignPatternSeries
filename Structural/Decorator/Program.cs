using Decorator.Exercise.End;
using Decorator.Solution;
using System;

namespace Decorator
{
    /// <summary>
    /// Also known as: Wrapper
    /// Decorator is a structural design pattern that lets you attach
    /// new behaviors to objects by placing these objects inside
    /// special wrapper objects that contain the behaviors.
    /// Decorator is similar in structure as the adapter pattern.
    /// The difference is that with the adapter pattern, we change
    /// the interface of a class to a different form.
    /// In contrast, with the decorator pattern, we add additional 
    /// begavior to an object.
    /// In both patterns, we are using composition.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new EncryptedCloudStream(new CompressedCloudStream(new CloudStream()));

            stream.Write("Hello world!");

            Console.WriteLine("--- Exercise ---");

            var editor = new Editor();

            editor.OpenProject("C:\\temp\\decorator");

            Console.ReadLine();
        }
    }
}
