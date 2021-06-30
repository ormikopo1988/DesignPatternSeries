namespace AbstractFactory
{
    /// <summary>
    /// The client code works with factories and products only
    /// through abstract types: IGUIFactory, IButton & ICheckbox. This
    /// lets you pass any factory or product subclass to the client
    /// code without breaking it.
    /// </summary>
    public class Application
    {
        private readonly IGUIFactory factory;
        private IButton button;
        private ICheckbox checkbox;

        public Application(IGUIFactory factory)
        {
            this.factory = factory;
        }

        public void CreateUI()
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
        }

        public void Paint()
        {
            button.Paint();
            checkbox.Paint();
        }
    }
}
