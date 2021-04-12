namespace Prototype
{
    /// <summary>
    /// Base prototype.
    /// </summary>
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Regular constructor.
        /// </summary>
        public Shape()
        {
            // Initialization logic...
        }

        /// <summary>
        /// The prototype constructor. A fresh object is initialized
        /// with values from the existing object.
        /// </summary>
        /// <param name="source"></param>
        public Shape(Shape source)
        {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        /// <summary>
        /// The clone operation returns one of the Shape subclasses.
        /// </summary>
        /// <returns></returns>
        public abstract Shape Clone();
    }
}
