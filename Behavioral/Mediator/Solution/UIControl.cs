namespace Mediator.Solution
{
    public abstract class UIControl
    {
        // Every UIControl knows about the DialogBox it resides into
        protected readonly DialogBox owner;

        public UIControl(DialogBox owner)
        {
            this.owner = owner;
        }
    }
}
