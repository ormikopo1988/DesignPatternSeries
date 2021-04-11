using System;

namespace Observer.Solution.PullStyle
{
    public class Chart : IObserver
    {
        private readonly DataSource dataSource;

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Chart object notified about new value in DataSource: {dataSource.Value}");
        }
    }
}
