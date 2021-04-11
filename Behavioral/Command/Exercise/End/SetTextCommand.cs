namespace Command.Exercise.End
{
    public class SetTextCommand : IUndoableCommand
    {
        private readonly string text;
        private readonly VideoEditor videoEditor;
        private readonly History history;

        public SetTextCommand(string text, VideoEditor videoEditor, History history)
        {
            this.text = text;
            this.videoEditor = videoEditor;
            this.history = history;
        }

        public void Execute()
        {
            videoEditor.Text = text;

            history.Push(this);
        }

        public void Undo()
        {
            videoEditor.RemoveText();
        }
    }
}
