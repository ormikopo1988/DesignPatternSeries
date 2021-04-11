using System;
using System.Collections.Generic;

namespace Proxy.Problem
{
    public class Library
    {
        private readonly Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();

        public void Add(Ebook ebook)
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
