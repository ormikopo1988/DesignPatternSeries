using System;

namespace Flyweight.Exercise.Start
{
    /// <summary>
    /// We’re going to build a spreadsheet application like Excel. 
    /// Classes in the Start folder show our current implementation of Cell and SpreadSheet concepts. 
    /// A user can set various formatting attributes such as font name, font size, bold, etc for each cell individually. 
    /// The problem with the current implementation is that each cell is storing its font family, font size and bold characteristics. 
    /// What if many cells share the same formatting attributes? 
    /// Storing these attributes for every cell would be a waste of memory. 
    /// While this is not a big deal in a small spreadsheet, it may cause our application to crash if we have a spreadsheet with 100,000+ rows of data. 
    /// Use the flyweight pattern to solve this problem. 
    /// </summary>
    public class SpreadSheet
    {
        private readonly int maxRows = 3;
        private readonly int maxCols = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private readonly string fontFamily = "Times New Roman";
        private readonly int fontSize = 12;
        private readonly bool isBold = false;

        private readonly Cell[,] cells;

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

            cells[row, col].FontFamily = fontFamily;
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
                    var cell = new Cell(row, col)
                    {
                        FontFamily = fontFamily
                    };
                    cells[row, col] = cell;
                }
            }
        }
    }
}
