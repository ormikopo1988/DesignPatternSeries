using System;
using System.Collections.Generic;

namespace Observer.Exercise.End
{
    public class StatusBar : IObserver
    {
        private readonly List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.Attach(this);
        }

        public void PriceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing status bar...");

            Show();
        }

        public void Show()
        {
            Console.WriteLine("Status bar");

            foreach (var stock in stocks)
            {
                Console.WriteLine(stock);
            }
        }
    }
}
