using System.Collections.Generic;

namespace Flyweight.Problem
{
    public class PointService
    {
        public List<Point> GetPoints()
        {
            return new List<Point>
            {
                new Point(1, 2, PointType.CAFE, null)
            };
        }
    }
}
