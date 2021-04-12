namespace FactoryMethod
{
    /// <summary>
    /// The creator class declares the factory method that must
    /// return an object of a product class. The creator's subclasses
    /// usually provide the implementation of this method.
    /// </summary>
    public abstract class Dialog
    {
        /// <summary>
        /// The creator may also provide some default implementation
        /// of the factory method.
        /// </summary>
        /// <returns></returns>
        public abstract IButton CreateButton();

        /// <summary>
        /// Note that, despite its name, the creator's primary
        /// responsibility isn't creating products. It usually
        /// contains some core business logic that relies on product
        /// objects returned by the factory method. Subclasses can
        /// indirectly change that business logic by overriding the
        /// factory method and returning a different type of product
        /// from it.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Render(int x, int y)
        {
            // Call the factory method to create a product object
            var okButton = CreateButton();

            // Now use the product object
            okButton.OnClick("closeDialog");
            okButton.Render(x, y);
        }
    }
}
