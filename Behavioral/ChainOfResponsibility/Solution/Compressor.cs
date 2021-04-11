using System;

namespace ChainOfResponsibility.Solution
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) 
            : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine($"Compressing http request from user {httpRequest.Username}.");

            return false;
        }
    }
}
