using System.Collections.Generic;

namespace Iterator.Exercise.Start
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
    }
}
