namespace Proxy.Solution
{
    public class EbookProxy : IEbook
    {
        private RealEbook realEbook; // We are not going to initialize this because it is costly. We will init this object whenever we really need to (inside the Show method)

        public string FileName { get; private set; }

        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            // In this example, we have lazy initialization before calling the actual RealEbook object.
            // Here we could also run other operations like logging, authorization etc.
            if (realEbook == null)
            {
                realEbook = new RealEbook(FileName);
            }

            realEbook.Show();
        }
    }
}
