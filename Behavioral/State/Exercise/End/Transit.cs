using System;

namespace State.Exercise.End
{
    public class Transit : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating ETA (transit)");

            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating Direction (transit)");

            return 3;
        }
    }
}
