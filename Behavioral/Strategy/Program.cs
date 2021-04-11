using Strategy.Exercise.End;
using Strategy.Solution;
using System;

namespace Strategy
{
    /// <summary>
    /// Strategy is a behavioral design pattern that lets you define a
    /// family of algorithms, put each of them into a separate class,
    /// and make their objects interchangeable.
    /// Strategy and state patterns have a very similar structure.
    /// The difference between them is that in the state pattern,
    /// the "Context" object can have a single state and all the behaviors (the "Context" class methods)
    /// are represented by a subclass of the "IState" interface.
    /// In contrast, in the strategy pattern, we do not have a single state in the "Context" object.
    /// Different behaviors are represented using different strategy objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var imageStorage1 = new ImageStorage(new PngCompressor(), new BlackAndWhiteFilterProcessor());
            imageStorage1.Store("file1");

            var imageStorage2 = new ImageStorage(new JpegCompressor(), new HighContrastFilterProcessor());
            imageStorage2.Store("file2");

            // We can also pass the strategy implementation objects in the method and not in the constructor to apply different behaviors to the same image.
            imageStorage2.Store("file2", new PngCompressor(), new HighContrastFilterProcessor());

            Console.WriteLine("--- Exercise ---");

            var chatClient1 = new ChatClient(new AesEncryptor());
            chatClient1.Send("Hello from chat client.");

            var chatClient2 = new ChatClient(new DesEncryptor());
            chatClient2.Send("Hello from chat client.");

            Console.ReadLine();
        }
    }
}
