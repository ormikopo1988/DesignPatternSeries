namespace Iterator.Exercise.End
{
    public interface IProductIterator
    {
        void Next();
        Product Current();
        bool HasNext();
    }
}
