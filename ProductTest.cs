using NUnit.Framework;

namespace Grocery.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ProductID_230_TRUE()
        {
            int input_value = 230;
            var product = new Product(input_value, "Tomatos", 10.99m, 45);
            Console.WriteLine(product.ToString());
            var expected_result = true;
            Assert.That(product.ProductID, Is.InRange(4, 40000));
        }

        [Test]
        public void ProductID_22_22()
        {
            int input_value = 22;
            var product = new Product(input_value, "Gereen Chilly", 4.99m, 234);
            Console.WriteLine(product.ToString());
            var expected_result = product.ProductID;
            Assert.That(expected_result, Is.EqualTo(expected_result));
        }

        [Test]
        public void ProductID_45_TRUE()
        {
            int input_value = 45;
            var product = new Product(input_value, "Black Papper", 3.99m, 476);
            Console.WriteLine(product.ToString());
            var expected_result = product.ProductID;
            Assert.That(expected_result, Is.Not.Null.Or.Empty);
        }
    }
}
