using System;
using System.Collections.Generic;

namespace Prototype
{
    /// <summary>
    /// Also known as: Clone
    /// Prototype is a creational design pattern that lets you copy
    /// existing objects without making your code dependent on
    /// their classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Somewhere in the client code.
            var shapes = new List<Shape>();
            var circle = new Circle(10, 10, "Red");
            circle.Radius = 20;

            shapes.Add(circle);

            var anotherCircle = circle.Clone();

            // The `anotherCircle` variable contains an exact copy
            // of the `circle` object.
            shapes.Add(anotherCircle);

            var rectangle = new Rectangle(20, 20, "Blue");

            shapes.Add(rectangle);

            var shapesCopy = new List<Shape>();

            // Prototype lets you produce a copy of
            // an object without knowing anything about its type.
            // For instance, we don't know the exact elements in the
            // shapes array. All we know is that they are all
            // shapes. But thanks to polymorphism, when we call the
            // `Clone` method on a shape the program checks its real
            // class and runs the appropriate clone method defined
            // in that class. That's why we get proper clones
            // instead of a set of simple Shape objects.
            foreach (var shape in shapes)
            {
                shapesCopy.Add(shape.Clone());
            }

            // The `shapesCopy` array contains exact copies of the
            // `shape` array's children, but they are entirely different objects.
            var circleOne = shapes[0];
            var circleTwo = shapes[1];
            var rectangleOne = shapes[2];

            var copyOfCircleOne = shapesCopy[0];
            var copyOfCircleTwo = shapesCopy[1];
            var copyOfRectangleOne = shapesCopy[2];

            Console.WriteLine("- circleOne / copyOfCircleOne - ");
            Console.WriteLine($"X values ({circleOne.X}) are equal: {circleOne.X == copyOfCircleOne.X}");
            Console.WriteLine($"Y values ({circleOne.Y}) are equal: {circleOne.Y == copyOfCircleOne.Y}");
            Console.WriteLine($"Color values ({circleOne.Color}) are equal: {circleOne.Color == copyOfCircleOne.Color}");
            Console.WriteLine($"circleOne is same object with copyOfCircleOne: {circleOne == copyOfCircleOne}");

            Console.WriteLine("- circleTwo / copyOfCircleTwo - ");
            Console.WriteLine($"X values ({circleTwo.X}) are equal: {circleTwo.X == copyOfCircleTwo.X}");
            Console.WriteLine($"Y values ({circleTwo.Y}) are equal: {circleTwo.Y == copyOfCircleTwo.Y}");
            Console.WriteLine($"Color values ({circleTwo.Color}) are equal: {circleTwo.Color == copyOfCircleTwo.Color}");
            Console.WriteLine($"circleTwo is same object with copyOfCircleTwo: {circleTwo == copyOfCircleTwo}");

            Console.WriteLine("- rectangleOne / copyOfRectangleOne - ");
            Console.WriteLine($"X values ({rectangleOne.X}) are equal: {rectangleOne.X == copyOfRectangleOne.X}");
            Console.WriteLine($"Y values ({rectangleOne.Y}) are equal: {rectangleOne.Y == copyOfRectangleOne.Y}");
            Console.WriteLine($"Color values ({rectangleOne.Color}) are equal: {rectangleOne.Color == copyOfRectangleOne.Color}");
            Console.WriteLine($"rectangleOne is same object with copyOfRectangleOne: {rectangleOne == copyOfRectangleOne}");

            Console.ReadLine();
        }
    }
}
