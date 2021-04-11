using System;

namespace Flyweight.Exercise.End
{
    public class SpreadSheet
    {
        private readonly int maxRows = 3;
        private readonly int maxCols = 3;
        private readonly Cell[,] cells;
        private readonly CellContextFactory contextFactory = new CellContextFactory();

        public SpreadSheet()
        {
            cells = new Cell[maxRows, maxCols];
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            cells[row, col].Content = content;
        }

        public void SetFontFamily(int row, int col, string fontFamily)
        {
            EnsureCellExists(row, col);

            var cell = cells[row, col];
            var currentContext = cell.Context;
            var context = contextFactory.Create(fontFamily, currentContext.FontSize, currentContext.IsBold);
            cells[row, col].Context = context;
        }

        public void Render()
        {
            for (var row = 0; row < maxRows; row++)
            {
                for (var col = 0; col < maxCols; col++)
                {
                    cells[row, col].Render();
                }
            }
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= maxRows)
            {
                throw new ArgumentException();
            }

            if (col < 0 || col >= maxCols)
            {
                throw new ArgumentException();
            }
        }

        private void GenerateCells()
        {
            for (var row = 0; row < maxRows; row++)
            {
                for (var col = 0; col < maxCols; col++)
                {
                    var cell = new Cell(row, col, new CellContext("Times New Roman", 12, false));

                    cells[row, col] = cell;
                }
            }
        }
    }
}
