namespace Mediator.Solution
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                isEnabled = value;

                this.owner.Changed(this);
            }
        }

        public Button(DialogBox dialogBox)
            : base(dialogBox)
        {
        }
    }
}
