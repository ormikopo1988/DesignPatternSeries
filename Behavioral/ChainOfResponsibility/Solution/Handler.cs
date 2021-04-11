namespace ChainOfResponsibility.Solution
{
    public abstract class Handler
    {
        protected readonly Handler Next;

        public Handler(Handler next)
        {
            Next = next;
        }

        /// <summary>
        /// We use here the template method pattern to create a blueprint for the process of our execution.
        /// </summary>
        /// <param name="httpRequest"></param>
        public void Handle(HttpRequest httpRequest)
        {
            if (DoHandle(httpRequest))
            {
                return;
            }

            if (Next != null)
            {
                Next.Handle(httpRequest);
            }
        }

        protected abstract bool DoHandle(HttpRequest httpRequest);
    }
}
