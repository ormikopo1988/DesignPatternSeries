using System;

namespace ChainOfResponsibility.Problem
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest httpRequest)
        {
            Console.WriteLine("Authenticating http request.");

            var isValid = (httpRequest.Username == "admin" && httpRequest.Password == "1234");

            return isValid;
        }
    }
}
