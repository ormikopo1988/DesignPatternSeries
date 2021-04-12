namespace AbstractFactory
{
    /// <summary>
    /// Each distinct product of a product family should have a base
    /// interface. All variants of the product must implement this
    /// interface.
    /// </summary>
    public interface IButton
    {
        void Paint();
    }
}
