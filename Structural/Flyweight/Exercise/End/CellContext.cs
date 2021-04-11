namespace Flyweight.Exercise.End
{
    public class CellContext
    {
        public string FontFamily { get; private set; }
        public int FontSize { get; private set; }
        public bool IsBold { get; private set; }

        public CellContext(string fontFamily, int fontSize, bool isBold)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;
            IsBold = isBold;
        }

        public override int GetHashCode()
        {
            return FontFamily.GetHashCode() + FontSize.GetHashCode() + IsBold.GetHashCode();
        }
    }
}
