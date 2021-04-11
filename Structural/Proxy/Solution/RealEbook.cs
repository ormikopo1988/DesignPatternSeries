using System;

namespace Proxy.Solution
{
    public class RealEbook : IEbook
    {
        public string FileName { get; private set; }

        public RealEbook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        public void Show()
        {
            Console.WriteLine($"Showing the ebook: {FileName}");
        }

        private void Load()
        {
            Console.WriteLine($"Loading the ebook: {FileName} from the file system.");
        }
    }
}
