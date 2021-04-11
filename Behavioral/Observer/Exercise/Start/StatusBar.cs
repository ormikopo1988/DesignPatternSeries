using System;
using System.Collections.Generic;

namespace Observer.Exercise.Start
{
    public class StatusBar
    {
        private readonly List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }

        public void Show()
        {
            foreach (var stock in stocks)
            {
                Console.WriteLine(stock);
            }
        }
    }
}
