using System.Collections.Generic;

namespace Memento.Exercise.End
{
    public class History
    {
        private readonly Stack<DocumentState> states = new Stack<DocumentState>();

        public void Push(DocumentState state)
        {
            states.Push(state);
        }

        public DocumentState Pop()
        {
            return states.Pop();
        }
    }
}
