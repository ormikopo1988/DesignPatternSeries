using System;

namespace ChainOfResponsibility.Solution
{
    public class Logger : Handler
    {
        public Logger(Handler next)
            : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine($"Logging http request from user {httpRequest.Username}.");

            return false;
        }
    }
}
