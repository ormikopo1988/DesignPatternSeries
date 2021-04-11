using System;

namespace Decorator.Problem
{
    /// <summary>
    /// Class for writing data to a cloud storage
    /// </summary>
    public class CloudStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine($"Storing {data} in the cloud.");
        }
    }
}
