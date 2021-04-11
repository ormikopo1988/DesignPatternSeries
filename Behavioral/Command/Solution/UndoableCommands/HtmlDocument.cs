namespace Command.Solution.UndoableCommands
{
    /// <summary>
    /// Business logic of our HTML editor app. 
    /// This is in our business logic layer of our app. It does not know anything about commands.
    /// Commands are the glue between user interface objects and business layer objects that contain the actual logic of our app.
    /// </summary>
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content = $"<b>{Content}</b>";
        }
    }
}
