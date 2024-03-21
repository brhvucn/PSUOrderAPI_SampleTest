using Order.API.Models;

namespace Order.API.Tests
{
    /// <summary>
    /// These are tests that are used to validate the product class/object
    /// </summary>
    public class ProductTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProduct_ValidConstructor_ExpectSuccess()
        {
            //Arrange + Act
            Product product = new Product("SKU1", "Volleyball", 25000);
            //Assert
            Assert.That(product.SKU, Is.EqualTo("SKU1"));
        }

        [Test]
        public void TestProduct_InvalidConstructorSKU_ExpectException()
        {
            //Arrange
            Action action = () => new Product("", "Volleyball", 25000);
            //act + assert
            Assert.Throws<ArgumentException>(() => action());

        }

        [Test]
        public void TestProduct_InvalidConstructorSKUNull_ExpectException()
        {
            //Arrange
            Action action = () => new Product(null, "Volleyball", 25000);
            //act + assert
            Assert.Throws<ArgumentNullException>(() => action());

        }

        [Test]
        public void TestProduct_InvalidConstructorSKUEmpty_ExpectException()
        {
            //Arrange
            Action action = () => new Product(" ", "Volleyball", 25000);
            //act + assert
            Assert.Throws<ArgumentException>(() => action());

        }

        [Test]
        public void TestProduct_InvalidConstructorName_ExpectException()
        {
            //Arrange
            Action action = () => new Product("SKU1", "", 25000);
            //act + assert
            Assert.Throws<ArgumentException>(() => action());

        }

        [Test]
        public void TestProduct_InvalidConstructorNameEmpty_ExpectException()
        {
            //Arrange
            Action action = () => new Product("SKU1", " ", 25000);
            //act + assert
            Assert.Throws<ArgumentException>(() => action());

        }

        [Test]
        public void TestProduct_InvalidConstructorNameNull_ExpectException()
        {
            //Arrange
            Action action = () => new Product("SKU1", null, 25000);
            //act + assert
            Assert.Throws<ArgumentNullException>(() => action());

        }

        [Test]
        public void TestProduct_InvalidConstructorPrice0_ExpectException()
        {
            //Arrange
            Action action = () => new Product("SKU1", "", 0);
            //act + assert
            Assert.Throws<ArgumentException>(() => action());

        }

        [Test]
        public void TestProduct_InvalidConstructorPriceNegative_ExpectException()
        {
            //Arrange
            Action action = () => new Product("SKU1", "", -17);
            //act + assert
            Assert.Throws<ArgumentException>(() => action());

        }        
    }
}