namespace Proxy.Exercise.End
{
    public class ProductProxy : Product
    {
        private readonly DbContext context;
        private string name;

        public override string Name 
        {
            get
            {
                return name;
            } 
            set 
            {
                name = value;

                context.MarkAsChanged(this);
            } 
        }

        public ProductProxy(int id, DbContext context) : base(id)
        {
            this.context = context;
        }
    }
}
