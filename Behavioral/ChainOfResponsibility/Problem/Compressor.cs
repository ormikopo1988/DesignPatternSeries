using System;

namespace ChainOfResponsibility.Problem
{
    public class Compressor
    {
        public void Compress(HttpRequest request)
        {
            Console.WriteLine($"Compressing http request from user {request.Username}.");
        }
    }
}
