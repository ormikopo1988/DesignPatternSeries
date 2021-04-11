using System.Collections.Generic;

namespace Adapter.Exercise.Start
{
    public class EmailClient
    {
        private List<IEmailProvider> providers = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider provider)
        {
            providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in providers)
            {
                provider.DownloadEmails();
            }
        }
    }
}
