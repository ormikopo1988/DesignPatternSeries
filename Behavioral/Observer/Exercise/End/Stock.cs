namespace Observer.Exercise.End
{
    public class Stock : Observable
    {
        public string Symbol { get; private set; }
        public float Price { get; private set; }

        public Stock(string symbol, float price)
        {
            Symbol = symbol;
            Price = price;
        }

        public void SetPrice(float price)
        {
            Price = price;
            Notify();
        }

        public override string ToString()
        {
            return "Stock{" +
                "symbol='" + Symbol + '\'' +
                ", price=" + Price +
            '}';
        }
    }
}
