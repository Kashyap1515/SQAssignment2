namespace Grocery
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

        public void IncreaseStock(int itemStock)
        {
            if (itemStock > 0)
            {
                var newStock = Stock + itemStock;
                if (newStock >= 4 && newStock <= 400000)
                {
                    Stock = newStock;
                }
                else
                {
                    throw new InvalidOperationException("Stock should be between 4 to 400000 only.");
                }
            }
            else
            {
                throw new InvalidOperationException("Amount should be positive.");
            }
        }

        public void DecreaseStock(int itemStock)
        {
            if (itemStock > 0 && Stock >= itemStock)
            {
                var newStock = Stock - itemStock;
                if (newStock >= 4 && newStock <= 400000)
                {
                    Stock = newStock;
                }
                else
                {
                    throw new InvalidOperationException("Stock should be between 4 to 400000 only.");
                }
            }
            else if (itemStock <= 0)
            {
                throw new InvalidOperationException("Amount should be positive.");
            }
            else
            {
                throw new InvalidOperationException("Insufficient stock.");
            }
        }

        public override string ToString()
        {
            return $"Product ID: {ProductID}, Product Name: {ProductName}, Price: {Price}, Stock: {Stock}";
        }
    }
}
