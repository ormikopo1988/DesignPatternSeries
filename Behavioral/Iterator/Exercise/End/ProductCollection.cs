using System.Collections.Generic;

namespace Iterator.Exercise.End
{
    /// <summary>
    /// This class only allows us to add a product to a collection. 
    /// Once we add a bunch of products to a collection, there is no way to iterate that collection and print the products. 
    /// Implement this feature using the iterator pattern.  
    /// </summary>
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
        }

        public IProductIterator CreateIterator()
        {
            return new ListProductIterator(this);
        }

        public class ListProductIterator : IProductIterator
        {
            private readonly ProductCollection productCollection;
            private int currentIndex;

            public ListProductIterator(ProductCollection productCollection)
            {
                this.productCollection = productCollection;
            }

            public Product Current()
            {
                return productCollection.products[currentIndex];
            }

            public bool HasNext()
            {
                return (currentIndex < productCollection.products.Count);
            }

            public void Next()
            {
                currentIndex++;
            }
        }
    }
}
