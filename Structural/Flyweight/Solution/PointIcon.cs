namespace Flyweight.Solution
{
    public class PointIcon
    {
        public PointType Type { get; private set; }
        public byte[] Icon { get; private set; }

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            Icon = icon;
        }
    }
}
