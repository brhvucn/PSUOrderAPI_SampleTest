using Order.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.Tests
{
    public class OrderTests
    {
        [Test]
        public void OrderTest_AddValidProduct_ExpectSucces()
        {
            //Arrange
            Product volleyball = new Product("SKU1", "Volleyball", 25000);
            Order.API.Models.Order order = new Order.API.Models.Order();
            //Act
            order.AddProduct(volleyball);
            //Assert
            Assert.That(1, Is.EqualTo(order.Products.Count));
        }

        [Test]
        public void OrderTest_AddNullProduct_ExpectException()
        {
            //Arrange
            Product volleyball = new Product("SKU1", "Volleyball", 25000);
            Order.API.Models.Order order = new Order.API.Models.Order();
            Action action = () => order.AddProduct(null);
            //Act
            Assert.Throws<ArgumentNullException>(() => action());
            //Assert
            Assert.That(0, Is.EqualTo(order.Products.Count));
        }
    }
}
