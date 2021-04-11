namespace Mediator.Exercise.End
{
    public class CheckBox : UIControl
    {
        private bool isChecked;

        public bool IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                isChecked = value;

                NotifyEventHandlers();
            }
        }
    }
}
