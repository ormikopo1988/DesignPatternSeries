﻿namespace Command.Exercise.End
{
    public class UndoCommand : ICommand
    {
        private readonly History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.Size() > 0)
            {
                history.Pop().Undo();
            }
        }
    }
}
