namespace Memento.Exercise.End
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

        public override string ToString()
        {
            return "Document{" +
                "Content='" + Content + '\'' +
                ", FontName='" + FontName + '\'' +
                ", FontSize=" + FontSize +
            '}';
        }
    }
}
