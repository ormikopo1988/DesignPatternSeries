namespace Mediator.Solution
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

                this.owner.Changed(this);
            }
        }

        public TextBox(DialogBox dialogBox)
            : base(dialogBox)
        {
        }
    }
}
