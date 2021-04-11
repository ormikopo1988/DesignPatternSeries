namespace Iterator.Solution
{
    public interface IElementIterator<T>
    {
        void Next();
        T Current();
        bool HasNext();
    }
}
