namespace Command.Solution.UndoableCommands
{
    public class BoldCommand : IUndoableCommand
    {
        private string prevContent;
        private readonly HtmlDocument htmlDocument;
        private readonly History history;

        public BoldCommand(HtmlDocument htmlDocument, History history)
        {
            this.htmlDocument = htmlDocument;
            this.history = history;
        }

        public void Execute()
        {
            prevContent = htmlDocument.Content;
            htmlDocument.MakeBold();
            history.Push(this);
        }

        public void Unexecute()
        {
            htmlDocument.Content = prevContent;
        }
    }
}
