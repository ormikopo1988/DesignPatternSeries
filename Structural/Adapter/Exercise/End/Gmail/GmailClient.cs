using System;

namespace Adapter.Exercise.End.Gmail
{
    public class GmailClient
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Gmail.");
        }

        public void GetEmails()
        {
            Console.WriteLine("Downloading emails from Gmail.");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from Gmail.");
        }
    }
}
