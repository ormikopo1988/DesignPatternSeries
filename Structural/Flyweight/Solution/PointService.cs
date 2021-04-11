using System.Collections.Generic;

namespace Flyweight.Solution
{
    public class PointService
    {
        private readonly PointIconFactory pointIconFactory = new PointIconFactory();

        public List<Point> GetPoints()
        {
            return new List<Point>
            {
                new Point(1, 2, pointIconFactory.Create(PointType.CAFE)),
                new Point(3, 4, pointIconFactory.Create(PointType.HOSPITAL)),
                new Point(5, 6, pointIconFactory.Create(PointType.RESTAURANT)),
                new Point(7, 8, pointIconFactory.Create(PointType.CAFE)),
                new Point(9, 10, pointIconFactory.Create(PointType.HOSPITAL)),
                new Point(11, 12, pointIconFactory.Create(PointType.RESTAURANT))
            };
        }
    }
}
