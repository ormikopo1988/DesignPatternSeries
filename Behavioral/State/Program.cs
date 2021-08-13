using State.Exercise.End;
using State.Solution;
using System;

namespace State
{
    /// <summary>
    /// State is a behavioral design pattern that lets an object alter its
    /// behavior when its internal state changes. It appears as if the
    /// object changed its class.
    /// e.g. The Canvas object's MouseDown and MouseUp methods in the current example
    /// behave differently depending on the value of the "Tool" object that is selected.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new Selection();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new Eraser();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new Brush();
            canvas.MouseDown();
            canvas.MouseUp();

            Console.WriteLine("--- Exercise ---");

            var directionService = new DirectionService(new Driving());
            Console.WriteLine(directionService.CalculateEstimatedTimeOfArrival());
            Console.WriteLine(directionService.CalculateDistance());

            directionService.ChangeTravelMode(new Bicycling());
            Console.WriteLine(directionService.CalculateEstimatedTimeOfArrival());
            Console.WriteLine(directionService.CalculateDistance());

            directionService.ChangeTravelMode(new Transit());
            Console.WriteLine(directionService.CalculateEstimatedTimeOfArrival());
            Console.WriteLine(directionService.CalculateDistance());

            directionService.ChangeTravelMode(new Walking());
            Console.WriteLine(directionService.CalculateEstimatedTimeOfArrival());
            Console.WriteLine(directionService.CalculateDistance());

            Console.ReadLine();
        }
    }
}
