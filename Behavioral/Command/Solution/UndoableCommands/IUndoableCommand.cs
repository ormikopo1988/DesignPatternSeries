namespace Command.Solution.UndoableCommands
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
