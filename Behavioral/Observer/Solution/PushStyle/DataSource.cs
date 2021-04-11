namespace Observer.Solution.PushStyle
{
    public class DataSource : Observable
    {
        public int Value { get; private set; }

        public void SetValue(int value)
        {
            Value = value;
            Notify(value);
        }
    }
}
