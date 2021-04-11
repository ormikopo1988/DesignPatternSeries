namespace Mediator.Exercise.End
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

                NotifyEventHandlers();
            }
        }
    }
}
