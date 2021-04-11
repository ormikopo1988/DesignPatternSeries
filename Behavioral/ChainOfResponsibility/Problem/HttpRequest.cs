namespace ChainOfResponsibility.Problem
{
    public class HttpRequest
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
