namespace Memento.Exercise.Start
{
    /// <summary>
    /// This class represents a document in a word processor like MS Word or Apple Pages.
    /// Our Document class has three attributes:  
    ///     -Content 
    ///     -FontName 
    ///     -FontSize
    /// We should allow the user to undo the changes to any of these attributes. 
    /// In the future, we may add additional attributes in this class and these attributes should also be undoable. 
    /// Implement the undo feature using the memento pattern. 
    /// </summary>
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

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
