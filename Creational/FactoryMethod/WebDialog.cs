namespace FactoryMethod
{
    /// <summary>
    /// Concrete creators override the factory method to change the
    /// resulting product's type.
    /// </summary>
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}
