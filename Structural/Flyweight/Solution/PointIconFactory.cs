using System.Collections.Generic;

namespace Flyweight.Solution
{
    public class PointIconFactory
    {
        private readonly Dictionary<PointType, PointIcon> pointTypeIcons = new Dictionary<PointType, PointIcon>();

        public PointIcon Create(PointType pointType)
        {
            if (pointTypeIcons.ContainsKey(pointType))
            {
                return pointTypeIcons[pointType];
            }

            var pointIcon = new PointIcon(pointType, null);

            pointTypeIcons.Add(pointType, pointIcon);

            return pointIcon;
        }
    }
}
