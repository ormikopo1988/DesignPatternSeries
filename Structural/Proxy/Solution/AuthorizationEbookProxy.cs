using System;

namespace Proxy.Solution
{
    public class AuthorizationEbookProxy : IEbook
    {
        private RealEbook realEbook;

        public string FileName { get; private set; }

        public AuthorizationEbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            Console.WriteLine("Checking authorization of the request before accessing the real ebook...");

            if (realEbook == null)
            {
                realEbook = new RealEbook(FileName);
            }

            realEbook.Show();
        }
    }
}
