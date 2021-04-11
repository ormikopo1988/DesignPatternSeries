namespace Command.Exercise.Start
{
    /// <summary>
    /// This class represents the operations we can perform on a video, such as adding a label to it or changing its contrast. 
    /// We need to allow the user to undo any changes he/she makes to a video. 
    /// What pattern would you use to implement this feature? 
    /// The memento or the command pattern? Why? 
    /// Write the necessary code to implement the undo feature.  
    /// </summary>
    public class VideoEditor
    {
        public float Contrast { get; set; } = 0.5f;
        public string Text { get; set; }

        public void RemoveText()
        {
            this.Text = "";
        }

        public override string ToString()
        {
            return "VideoEditor{" +
                "contrast=" + Contrast +
                ", text='" + Text + '\'' +
            '}';
        }
    }
}
