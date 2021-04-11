using System;

namespace Observer.Solution.PullStyle
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"SpreadSheet object notified about new value in DataSource: {dataSource.Value}");
        }
    }
}
