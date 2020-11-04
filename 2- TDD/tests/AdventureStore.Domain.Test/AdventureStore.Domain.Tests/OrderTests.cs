using System;
using Xunit;

namespace AdventureStore.Domain.Tests
{
    public class OrderTest
    {
        [Fact(DisplayName = "Order Close - The customer can only redeem products in they are in stock")]
        [Trait("Category", "Test Order")]
        public void OrderClose_ProductNotInStock_Error()
        {
            // Arrange
            var order = new Order();
            var itemOrder = new ItemOrder(Guid.NewGuid(), "", 250, 1);

            // Act
            var result = order.OrderClose(itemOrder, out string message);

            // Assert
            Assert.False(result, "This product is not in stock");

        }

        [Fact(DisplayName = "Order Add item - Before adding an item to the cart it is necessary to calculate the total order amount")]
        [Trait("Category", "Order test")]
        public void AddItem_CalculateTheTotalOrderAmount()
        {
            // Arrange
            var order = new Order();
            var itemOrder = new ItemOrder(Guid.NewGuid(), "Bicycle", 100, 2);

            // Act
            order.AddItem(itemOrder);

            // Assert
            Assert.Equal(200, order.TotalPrice);
        }
    }
}
