using System.Collections.Generic;

namespace Memento.Solution
{
    public class History
    {
        private readonly Stack<EditorState> states = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState Pop()
        {
            return states.Pop();
        }
    }
}
