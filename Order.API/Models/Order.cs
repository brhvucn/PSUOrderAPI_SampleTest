using EnsureThat;

namespace Order.API.Models
{
    public class Order
    {
        public Order() 
        {
            Products = new List<Product>();
            Created = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime Created { get; private set; }
        public List<Product> Products { get; private set; }

        public void AddProduct(Product product)
        {
            Ensure.That(product).IsNotNull();
            Products.Add(product); 
        }
    }    
}
