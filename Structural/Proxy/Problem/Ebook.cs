using System;

namespace Proxy.Problem
{
    public class Ebook
    {
        public string FileName { get; private set; }

        public Ebook(string fileName)
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
            Console.WriteLine($"Loading the ebook: {FileName}");
        }
    }
}
