namespace Iterator.Exercise.End
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return "Product{" +
                "id=" + Id +
                ", name='" + Name + '\'' +
            '}';
        }
    }
}
