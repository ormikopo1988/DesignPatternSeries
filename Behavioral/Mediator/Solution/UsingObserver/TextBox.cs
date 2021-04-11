namespace Mediator.Solution.UsingObserver
{
    public class TextBox : UIControl
    {
        private string content;

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;

                NotifyEventHandlers();
            }
        }
    }
}
