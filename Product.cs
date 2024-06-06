namespace Groccery
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            if (amount > 0)
            {
                Stock += amount;
            }
        }

        public void DecreaseStock(int amount)
        {
            if (amount > 0 && Stock >= amount)
            {
                Stock -= amount;
            }
        }
        public override string ToString()
        {
            return $"Product ID: {ProductID}, Product Name: {ProductName}, Price: {Price}, Stock: {Stock}";
        }
    }
}
