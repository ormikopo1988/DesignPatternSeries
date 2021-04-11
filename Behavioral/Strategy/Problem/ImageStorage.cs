using System;

namespace Strategy.Problem
{
    public class ImageStorage
    {
        private readonly string compressor; // JPEG, PNG, ...
        private readonly string filter; // Black & White, High Contrast, ...

        public ImageStorage(string compressor, string filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void Store(string fileName)
        {
            if (compressor == "jpeg")
            {
                Console.WriteLine("Compressing using JPEG.");
            }
            else if (compressor == "png")
            {
                Console.WriteLine("Compressing using PNG.");
            }

            if (filter == "b&w")
            {
                Console.WriteLine("Applying B&W filter.");
            }
            else if (filter == "high-contrast")
            {
                Console.WriteLine("Applying high contrast filter.");
            }

            Console.WriteLine($"Store image with name {fileName}.");
        }
    }
}
