using System;

namespace Flyweight.Problem
{
    public class Point
    {
        private readonly int x; // 4 bytes
        private readonly int y; // 4 bytes
        private readonly PointType type; // 4 bytes
        private readonly byte[] icon; // Lets say ~20 KB - If this was about a mobile application for a map then if each point in the map wanted 20 KB for its icon, then if we had 1000 points, we would need ~20 MB of memory for each individual point object

        public Point(int x, int y, PointType type, byte[] icon)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{type} at ({x}, {y})");
        }
    }
}
