using EnsureThat;

namespace Order.API.Models
{
    public class Product
    {
        public Product(string sku, string name, int price)
        {
            Ensure.That(sku, nameof(sku)).IsNotNullOrWhiteSpace();
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();
            Ensure.That(price, nameof(price)).IsGt<int>(0);

            this.SKU = sku;
            this.Name = name;
            this.Price = price;
        }
        public int Id { get; set; }
        public string SKU { get; private set; }
        public string Name { get; private set; }
        public string Description { get; set; }
        public int Price { get; private set; }
    }
}
