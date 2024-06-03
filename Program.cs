namespace Assignment2;
class Assignment2
{
    static void Main(string[] args)
    {
        Product product1 = new Product(1, "Milk", 40);
        Console.WriteLine("Current Milk Stock : " + product1.PStock);

        product1.IncreaseStockCount(10);
        Console.WriteLine("After Increase Milk Stock : " + product1.PStock);

        Product product2 = new Product(2, "Cheese", 60);
        Console.WriteLine("Current Cheese Stock : " + product2.PStock);

        product2.DecreaseStockCount(15);
        Console.WriteLine("After Decrease Cheese Stock : " + product2.PStock);
    }
}
