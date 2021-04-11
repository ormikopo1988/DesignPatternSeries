using System;
using System.Collections.Generic;

namespace Proxy.Solution
{
    public class Library
    {
        private readonly Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>();

        public void Add(IEbook ebook)
        {
            if (!ebooks.ContainsKey(ebook.FileName)) 
            {
                ebooks.Add(ebook.FileName, ebook);
            }
        }

        public void OpenEbook(string fileName)
        {
            if (!ebooks.ContainsKey(fileName))
            {
                throw new ArgumentException("The ebook with this filename does not exist.");
            }

            var ebook = ebooks[fileName];

            ebook.Show();
        }
    }
}
