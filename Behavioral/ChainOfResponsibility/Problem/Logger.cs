using System;

namespace ChainOfResponsibility.Problem
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            Console.WriteLine($"Logging http request from user {request.Username}.");
        }
    }
}
