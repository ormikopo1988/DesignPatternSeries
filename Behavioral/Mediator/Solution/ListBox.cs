namespace Mediator.Solution
{
    public class ListBox : UIControl
    {
        private string selection;

        public string Selection
        {
            get 
            { 
                return selection; 
            }
            set 
            {
                selection = value;

                this.owner.Changed(this);
            }
        }

        public ListBox(DialogBox dialogBox)
            : base(dialogBox)
        {
        }
    }
}
