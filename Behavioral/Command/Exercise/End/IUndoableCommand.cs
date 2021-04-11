namespace Command.Exercise.End
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }
}
