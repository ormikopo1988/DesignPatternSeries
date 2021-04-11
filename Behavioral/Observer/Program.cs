using Observer.Exercise.End;
using System;
using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    /// Also known as: Event-Subscriber, Listener
    /// Observer is a behavioral design pattern that lets you define a
    /// subscription mechanism to notify multiple objects about any
    /// events that happen to the object they’re observing.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Pull Style Observer Pattern
            var pullStyleDataSource = new Solution.PullStyle.DataSource();
            var pullStyleChart = new Solution.PullStyle.Chart(pullStyleDataSource);
            pullStyleDataSource.Attach(pullStyleChart);
            var pullStyleSpreadSheet = new Solution.PullStyle.SpreadSheet(pullStyleDataSource);
            pullStyleDataSource.Attach(pullStyleSpreadSheet);

            pullStyleDataSource.SetValue(10);

            pullStyleDataSource.Dettach(pullStyleSpreadSheet);

            pullStyleDataSource.SetValue(50);

            // Push Style Observer Pattern
            var pushStyleDataSource = new Solution.PushStyle.DataSource();
            var pushStyleChart = new Solution.PushStyle.Chart();
            pushStyleDataSource.Attach(pushStyleChart);
            var pushStyleSpreadSheet = new Solution.PushStyle.SpreadSheet();
            pushStyleDataSource.Attach(pushStyleSpreadSheet);

            pushStyleDataSource.SetValue(10);

            pushStyleDataSource.Dettach(pushStyleSpreadSheet);

            pushStyleDataSource.SetValue(50);

            Console.WriteLine("--- Exercise ---");

            var listOfStocks = new List<Stock>
            {
                new Stock("Stock1", 10),
                new Stock("Stock2", 20),
                new Stock("Stock3", 30),
            };

            var statusBar = new StatusBar();
            statusBar.AddStock(listOfStocks[0]);
            var stockListView = new StockListView();
            stockListView.AddStock(listOfStocks[1]);
            stockListView.AddStock(listOfStocks[2]);

            listOfStocks[0].SetPrice(15);
            listOfStocks[1].SetPrice(25);
            listOfStocks[2].SetPrice(35);

            listOfStocks[1].Dettach(stockListView);

            listOfStocks[0].SetPrice(25);
            listOfStocks[1].SetPrice(35);
            listOfStocks[2].SetPrice(45);

            Console.ReadLine();
        }
    }
}
