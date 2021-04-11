using System;

namespace Strategy.Solution
{
    public class JpegCompressor : ICompressorStrategy
    {
        public void ApplyCompression(string fileName)
        {
            Console.WriteLine($"Compressing using JPEG file with name {fileName}.");
        }
    }
}
