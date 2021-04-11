using Adapter.Exercise.End.Gmail;

namespace Adapter.Exercise.End
{
    public class GmailProviderAdapter : IEmailProvider
    {
        private readonly GmailClient gmailClient = new GmailClient();

        public void DownloadEmails()
        {
            gmailClient.Connect();
            gmailClient.GetEmails();
            gmailClient.Disconnect();
        }
    }
}
