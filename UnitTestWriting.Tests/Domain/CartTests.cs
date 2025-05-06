using System;
using UnitTestWriting.Domain;
using Xunit;

namespace UnitTestWriting.Tests.Domain
{
    public class CartTests
    {
        [Fact]
        public void NewCart_ShouldHaveNoProducts()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = "MyNewUser",
                BirthDate = new DateTime(1990, 1, 1),
                Premium = false
            };

            var cart = new Cart(user);

            // Act
            var products = cart.Products;

            // Assert
            Assert.Empty(products);
        }
    }
}