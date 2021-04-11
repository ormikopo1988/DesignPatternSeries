namespace Proxy.Exercise.End
{
    public class Product
    {
        public int Id { get; private set; }
        public virtual string Name { get; set; }

        public Product(int id)
        {
            Id = id;
        }
    }
}
