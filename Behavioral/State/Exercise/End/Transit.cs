using System;

namespace State.Exercise.End
{
    public class Transit : ITravelMode
    {
        public int CalculateEstimatedTimeOfArrival()
        {
            Console.WriteLine("Calculating Estimated Time of Arrival (transit)");

            return 3;
        }

        public int CalculateDistance()
        {
            Console.WriteLine("Calculating Direction (transit)");

            return 3;
        }
    }
}
