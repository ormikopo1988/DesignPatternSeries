using System;

namespace ChainOfResponsibility.Exercise.End
{
    public abstract class Handler
    {
        private Handler next;

        public void SetNext(Handler next)
        {
            this.next = next;
        }

        public void Handle(string fileName)
        {
            if (DoHandle(fileName))
            {
                return;
            }

            if (next != null)
            {
                next.Handle(fileName);
            }
            else
            {
                throw new InvalidOperationException("File format not supported.");
            }
        }

        protected abstract bool DoHandle(string fileName);
    }
}
