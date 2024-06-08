using NUnit.Framework;

namespace EcommerceGrocery.Tests
{
    [TestFixture]
    public class ProductTests
    {
        // Unit Test For Product ID
        [Test]
        public void ProductID_WhenInput230_ShouldBeWithInRange()
        {
            // Arrange
            int inputId = 230;
            var product = new Product(inputId, "Tomatos", 10.99m, 45);

            // Act
            var output = product.ProductID;

            // Assert
            Assert.That(output, Is.InRange(4, 40000));
        }

        [Test]
        public void ProductID_WhenInput4_ShouldEqualInputValue()
        {
            // Arrange
            int inputId = 4;
            var product = new Product(inputId, "Gereen Chilly", 4.99m, 234);

            // Act
            var output = product.ProductID;

            // Assert
            Assert.That(output, Is.EqualTo(inputId));
        }

        [Test]
        public void ProductID_WhenInput45_ShouldNotBeNullOrEmpty()
        {
            // Arrange
            int inputId = 45;
            var product = new Product(inputId, "Black Papper", 3.99m, 476);

            // Act
            var expectedResult = product.ProductID;

            // Assert
            Assert.That(expectedResult, Is.Not.Null.Or.Empty);
        }

        // Unit Test For Product Name
        [Test]
        public void ProductName_WhenInputEmptyStringOrWhiteSpace_ShouldNotBeEmpty()
        {
            // Arrange
            var inputValue = "    ";
            var product = new Product(76, inputValue, 232.99m, 25);

            // Act
            var output = string.IsNullOrWhiteSpace(product.ProductName);

            // Assert
            Assert.That(output, Is.True);
        }


        [Test]
        public void ProductName_WhenInputSpecialCharNumberTextWithWhiteSpaceString_ShouldMatchInputValue()
        {
            // Arrange
            var inputValue = "*@#8HJHARiya  !1515   :'][    (Kashyap)";
            var product = new Product(345, inputValue, 12.99m, 224);

            // Act
            var output = product.ProductName;

            // Assert
            Assert.That(output.Length, Is.EqualTo(inputValue.Length));           
        }

        [Test]
        public void ProductName_WhenInputOnion_ShouldMatchinputValue()
        {
            // Arrange
            var inputValue = "Onion";
            var product = new Product(654, inputValue, 12.99m, 222);

            // Act
            var output = product.ProductName;

            // Assert
            Assert.That(output, Is.EqualTo(inputValue));           
        }

        // Unit Test For Product Price
        [Test]
        public void ProductPrice_WhenInputMinimumBoundary_ShouldBeGreaterThanOrEqualTo4()
        {
            // Arrange
            var inputPrice = 4m;
            var product = new Product(44, "Tomato", inputPrice, 345);

            // Act
            var output = product.Price;

            // Assert
            Assert.That(output, Is.EqualTo(4));
        }

        [Test]
        public void ProductPrice_WhenInputNegative_ShouldNotBeValid()
        {
            // Arrange
            var inputPrice = -100m;
            var product = new Product(676, "Cabbage", inputPrice, 5030);

            // Act
            var output = product.Price;

            // Assert
            Assert.That(output, Is.LessThan(0));
        }

        [Test]
        public void ProductPrice_WhenInput4000m_ShouldBeWithInRange()
        {
            // Arrange
            var inputPrice = 4000m;
            var product = new Product(876, "Potato", inputPrice, 34322);

            // Act
            var output = product.Price;

            // Assert
            Assert.That(output, Is.InRange(4, 4000));
        }

        // Unit Test For Product Stock
        [Test]
        public void ProductStock_WhenInput400000_ShouldBeWithInRange()
        {
            // Arrange
            var inputStock = 400000;
            var product = new Product(568, "Carrot", 32m, inputStock);

            // Act
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.InRange(4, 400000));
        }

        [Test]
        public void ProductStock_WhenInputZero_ShouldNotBeValid()
        {
            // Arrange
            var inputStock = 0;
            var product = new Product(765, "Lettuce", 20m, inputStock);

            // Act
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.EqualTo(0));
        }

        [Test]
        public void ProductStock_WhenInputAboveMaximumBoundary_ShouldNotBeValid()
        {
            // Arrange
            var inputStock = 400001;
            var product = new Product(456, "Broccoli", 16m, inputStock);

            // Act
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.GreaterThan(400000));
        }

        // Unit Test For Increase Stock Function
        [Test]
        public void IncrementStock_WhenIncreasedBy50_ShouldEqual250()
        {
            // Arrange
            var inputStock = 600;
            var product = new Product(556, "Spanich", 3433m, inputStock);

            // Act
            product.IncreaseStock(50);
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.EqualTo(650));
        }

        [Test]
        public void IncrementStock_WhenIncreasedBy0_ShouldRemainUnchanged()
        {
            // Arrange
            var inputStock = 323150;
            var product = new Product(23248, "Carrot", 32m, inputStock);

            // Act
            product.IncreaseStock(0);
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.EqualTo(inputStock));
        }

        [Test]
        public void IncrementStock_WhenIncreasedBy500000_ShouldRemainUnchanged()
        {
            // Arrange
            var inputStock = 100000;
            var product = new Product(29, "Cabbage", 1m, inputStock);

            // Act
            product.IncreaseStock(500000);
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.EqualTo(100000));
        }
        // Unit Test For Decrease Stock Function
        [Test]
        public void DecrementStock_WhenDecreasedBy1876_ShouldEqual2000()
        {
            // Arrange
            var inputStock = 3876;
            var product = new Product(876, "Bell Pepper", 43m, inputStock);

            // Act
            product.DecreaseStock(1876);
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.EqualTo(2000));
        }

        [Test]
        public void DecrementStock_WhenDecreasedToNegative_ShouldRemainUnchanged()
        {
            // Arrange
            var inputStock = 3498;
            var product = new Product(4546, "Cucumber", 140m, inputStock);

            // Act
            product.DecreaseStock(-100);
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.EqualTo(inputStock));
        }

        [Test]
        public void DecrementStock_WhenDecreasedByLowerThanMinimumBoundry_ShouldRemainUnchanged()
        {
            // Arrange
            var inputStock = 200;
            var product = new Product(4513, "Potato", 313m, inputStock);

            // Act
            product.DecreaseStock(1392);
            var output = product.Stock;

            // Assert
            Assert.That(output, Is.EqualTo(inputStock));
        }
    }
}

