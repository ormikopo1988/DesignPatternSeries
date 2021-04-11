namespace Mediator.Exercise.End
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

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(content);
        }
    }
}
