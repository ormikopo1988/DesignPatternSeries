using System;

namespace Flyweight.Exercise.Start
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;

        public string Content { get; set; }
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public bool IsBold { get; set; }

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public void Render()
        {
            Console.WriteLine($"({row}, {column}): {Content} [{FontFamily}]");
        }
    }
}
