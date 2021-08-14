namespace Iterator.Solution
{
    public interface IIterableCollection<T>
    {
        IElementIterator<T> CreateIterator();
    }
}
