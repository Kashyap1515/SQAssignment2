namespace Assignment2;
public class Product
{
    public int PId { get; set; }
    public string PName { get; set; }
    public int PStock { get; set; }

    public Product(int productId, string productName, int productStock)
    {
        PId = productId;
        PName = productName;
        PStock = productStock;
    }

    public void IncreaseStockCount(int productStock)
    {
        if (productStock > 0)
        {
            PStock += productStock;
        }
    }

    public void DecreaseStockCount(int productStock)
    {
        if (productStock > 0)
        {
            PStock -= productStock;
        }
    }
}
