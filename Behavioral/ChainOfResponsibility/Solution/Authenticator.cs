using System;

namespace ChainOfResponsibility.Solution
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next)
            : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Authenticating http request.");

            var isValid = (httpRequest.Username == "admin" && httpRequest.Password == "1234");

            if (!isValid)
            {
                Console.WriteLine("Invalid credentials.");

                return true;
            }

            return false;
        }
    }
}
