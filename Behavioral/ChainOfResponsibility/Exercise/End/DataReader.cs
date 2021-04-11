namespace ChainOfResponsibility.Exercise.End
{
    public class DataReader
    {
        private readonly Handler handler;

        public DataReader(Handler handler)
        {
            this.handler = handler;
        }

        public void Read(string fileName)
        {
            handler.Handle(fileName);
        }
    }
}
