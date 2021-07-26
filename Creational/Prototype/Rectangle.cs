namespace Prototype
{
    /// <summary>
    /// Concrete prototype. The cloning method creates a new object
    /// and passes it to the constructor. Until the constructor is
    /// finished, it has a reference to a fresh clone. Therefore,
    /// nobody has access to a partly-built clone. This keeps the
    /// cloning result consistent.
    /// </summary>
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Regular constructor
        /// </summary>
        public Rectangle(int x, int y, string color)
            : base(x, y, color)
        {
        }

        /// <summary>
        /// A parent constructor call is needed to copy private
        /// fields defined in the parent class (X, Y, Color).
        /// </summary>
        /// <param name="source"></param>
        public Rectangle(Rectangle source) 
            : base(source)
        {
            Width = source.Width;
            Height = source.Height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
