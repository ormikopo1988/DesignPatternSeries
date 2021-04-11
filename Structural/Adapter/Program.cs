using Adapter.Exercise.End;
using Adapter.Solution;
using Adapter.Solution.ThirdPartyFilters;
using System;

namespace Adapter
{
    /// <summary>
    /// Also known as: Wrapper
    /// Adapter is a structural design pattern that allows objects with
    /// incompatible interfaces to collaborate.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new BlurFilter());
            imageView.Apply(new CaramelFilterAdapter(new CaramelFilter()));

            Console.WriteLine("--- Exercise ---");

            var emailClient = new EmailClient();
            emailClient.AddProvider(new GmailProviderAdapter());
            emailClient.DownloadEmails();

            Console.ReadLine();
        }
    }
}
