using System;

namespace Decorator.Solution
{
    public class CloudStream : IStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine($"Storing {data} in the cloud.");
        }
    }
}
