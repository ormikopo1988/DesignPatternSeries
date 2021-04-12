namespace FactoryMethod
{
    /// <summary>
    /// The product interface declares the operations that all
    /// concrete products must implement.
    /// </summary>
    public interface IButton
    {
        void Render(int x, int y);
        void OnClick(string eventName);
    }
}
