using System;

namespace Strategy.Solution
{
    public class PngCompressor : ICompressorStrategy
    {
        public void ApplyCompression(string fileName)
        {
            Console.WriteLine($"Compressing using PNG file with name {fileName}.");
        }
    }
}
