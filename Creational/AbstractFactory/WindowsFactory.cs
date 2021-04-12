namespace AbstractFactory
{
    /// <summary>
    /// Concrete factories produce a family of products that belong
    /// to a single variant. The factory guarantees that the
    /// resulting products are compatible. Signatures of the concrete
    /// factory's methods return an abstract product, while inside
    /// the method a concrete product is instantiated.
    /// Each concrete factory has a corresponding product variant.
    /// </summary>
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
