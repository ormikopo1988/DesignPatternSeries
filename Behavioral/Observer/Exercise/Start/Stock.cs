namespace Observer.Exercise.Start
{
    /// <summary>
    /// We’re building an application for watching the price of various stocks. 
    /// There are two places in our application where we need to display the stocks:  
    ///     -StatusBar: shows the popular stocks  
    ///     -StockListView: shows the complete list of stocks 
    /// When the price of a stock changes, the corresponding views (StatusBar and/or StockListView) need to be refreshed to reflect the latest price.
    /// Our application currently does not have the ability to communicate the change in stock prices to the corresponding views. 
    /// Use the observer pattern to solve this problem. 
    /// </summary>
    public class Stock
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
