namespace Facade.Exercise.End
{
    public class Tweet
    {
        public string Message { get; private set; }

        public Tweet(string message)
        {
            Message = message;
        }
    }
}
