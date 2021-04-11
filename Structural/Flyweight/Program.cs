using Flyweight.Exercise.Start;
using Flyweight.Solution;
using System;

namespace Flyweight
{
    /// <summary>
    /// Also known as: Cache
    /// Flyweight is a structural design pattern that lets you fit more
    /// objects into the available amount of RAM by sharing common
    /// parts of state between multiple objects instead of keeping all
    /// of the data in each object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var pointService = new PointService();

            var points = pointService.GetPoints();

            foreach (var point in points)
            {
                point.Draw();
            }

            Console.WriteLine("--- Exercise ---");

            var sheet = new SpreadSheet();
            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetFontFamily(0, 0, "Arial");
            sheet.Render();

            Console.ReadLine();
        }
    }
}
