using System;

namespace Strategy.Problem
{
    public enum Compressor
    {
        JPEG,
        PNG
    }

    public enum Filter
    {
        BLACKANDWHITE,
        HIGHCONTRAST
    }

    public class ImageStorage
    {
        private readonly Compressor compressor;
        private readonly Filter filter;

        public ImageStorage(Compressor compressor, Filter filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void Store(string fileName)
        {
            switch (compressor)
            {
                case Compressor.JPEG:
                    Console.WriteLine("Compressing using JPEG.");
                    break;
                case Compressor.PNG:
                    Console.WriteLine("Compressing using PNG.");
                    break;
                default:
                    throw new Exception("Unknown compression algorithm.");
            }

            switch (filter)
            {
                case Filter.BLACKANDWHITE:
                    Console.WriteLine("Applying B&W filter.");
                    break;
                case Filter.HIGHCONTRAST:
                    Console.WriteLine("Applying high contrast filter.");
                    break;
                default:
                    throw new Exception("Unknown filter type.");
            }

            Console.WriteLine($"Store image with name {fileName}.");
        }
    }
}
