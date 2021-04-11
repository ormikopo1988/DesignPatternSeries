namespace Command.Exercise.End
{
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
