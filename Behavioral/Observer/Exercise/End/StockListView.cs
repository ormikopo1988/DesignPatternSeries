using System;
using System.Collections.Generic;

namespace Observer.Exercise.End
{
    public class StockListView : IObserver
    {
        private readonly List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.Attach(this);
        }

        public void PriceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing stock list view...");

            Show();
        }

        public void Show()
        {
            Console.WriteLine("Stock list view");

            foreach (var stock in stocks)
            {
                Console.WriteLine(stock);
            }
        }
    }
}
