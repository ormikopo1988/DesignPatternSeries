namespace Memento.Exercise.End
{
    public class DocumentState
    {
        public string Content { get; private set; }
        public string FontName { get; private set; }
        public int FontSize { get; private set; }

        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    }
}
