namespace Prototype
{
    /// <summary>
    /// Concrete prototype. The Clone method creates a new object
    /// and passes it to the constructor. Until the constructor is
    /// finished, it has a reference to a fresh clone. Therefore,
    /// nobody has access to a partly-built clone. This keeps the
    /// cloning result consistent.
    /// </summary>
    public class Circle : Shape
    {
        public int Radius { get; set; }

        /// <summary>
        /// Regular constructor
        /// </summary>
        public Circle(int x, int y, string color)
            : base(x, y, color)
        {
        }

        /// <summary>
        /// A parent constructor call is needed to copy private
        /// fields defined in the parent class (X, Y, Color).
        /// </summary>
        /// <param name="source"></param>
        public Circle(Circle source)
            : base(source)
        {
            Radius = source.Radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
