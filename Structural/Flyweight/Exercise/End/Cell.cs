using System;

namespace Flyweight.Exercise.End
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;

        public CellContext Context { get; set; }
        public string Content { get; set; }
        
        public Cell(int row, int column, CellContext context)
        {
            this.row = row;
            this.column = column;
            Context = context;
        }

        public void Render()
        {
            Console.WriteLine($"({row}, {column}): {Content} [{Context.FontFamily}]");
        }
    }
}
