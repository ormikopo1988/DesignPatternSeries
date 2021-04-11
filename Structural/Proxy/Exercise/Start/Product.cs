namespace Proxy.Exercise.Start
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Product(int id)
        {
            Id = id;
        }
    }
}
