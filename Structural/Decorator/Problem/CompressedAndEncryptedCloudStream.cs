using System;

namespace Decorator.Problem
{
    /// <summary>
    /// The problem we are facing with this approach is that for every new feature
    /// we are adding, we need to create various than combine all these features.
    /// </summary>
    public class CompressedAndEncryptedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            Console.WriteLine("Compress data.");
            Console.WriteLine("Encrypt data.");

            base.Write(data);
        }
    }
}
