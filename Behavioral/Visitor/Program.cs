using System;
using Visitor.Exercise.End;
using Visitor.Solution;

namespace Visitor
{
    /// <summary>
    /// The visitor pattern allows us to add new operations to an object structure without modifying it.
    /// Visitor is a behavioral design pattern that lets you separate
    /// algorithms from the objects on which they operate.
    /// This pattern is best suited to be applied to object structures that we already know are stable.
    /// They do not change frequently.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.Add(new HeadingNode());
            htmlDocument.Add(new AnchorNode());

            htmlDocument.Execute(new HighlightOperation());
            htmlDocument.Execute(new PlainTextOperation());

            Console.WriteLine("--- Exercise ---");

            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile.AddSegment(new FormatSegment());
            wavFile.AddSegment(new FactSegment());

            wavFile.Execute(new ReduceNoise());
            wavFile.Execute(new AddReverb());
            wavFile.Execute(new Normalize());

            Console.ReadLine();
        }
    }
}
