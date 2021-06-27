using System;

namespace Adapter.Exercise.Start.Gmail
{
    /// <summary>
    /// We’re building an email client like Outlook. 
    /// Our client should be able to connect to different mail servers such as Gmail, Yahoo, etc. 
    /// In the Start folder of the Exercise, you can see an interface called IEmailProvider. 
    /// Our EmailClient class talks to this interface so it’s not coupled to a particular mail service. 
    /// Here’s the problem: In the current file, you can find the class that Google provides to connect to Gmail. 
    /// This class is shipped as a third-party library that we can add to our application. 
    /// We want to re-use this class but the GmailClient class does not extend our IEmailProvider interface. 
    /// Use the adapter pattern to convert the interface of GmailClient.
    /// </summary>
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
