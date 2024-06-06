using NUnit.Framework;

namespace Groccery.Tests
{
    [TestFixture]
    public class GrocceryTests
    {

        [Test]
        public void ShouldBeWithinRange_230_230()
        {
            int input_value = 230;
            var product = new Product(input_value, "Tomatos", 10.99m, 45);
            Console.WriteLine(product.ToString());
            var expected_result = product.ProductID;
            Assert.That(expected_result, Is.InRange(4, 40000));
        }

        [Test]
        public void CheckProductId_22_22()
        {
            int input_value = 22;
            var product = new Product(input_value, "Gereen Chilly", 4.99m, 234);
            Console.WriteLine(product.ToString());
            int expected_result = 22;
            var productID = product.ProductID;
            Assert.That(productID, Is.EqualTo(expected_result));
        }
    }
}
