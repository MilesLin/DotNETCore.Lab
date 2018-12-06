using DotNETCore.Lab.Lab3_Assertion;
using ExpectedObjects;
using System;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab3_Assertion
{
    public class MyServiceTests
    {
        private MyService CreateService()
        {
            return new MyService();
        }

        [Fact]
        public void IsValidBankName_SetValidBankName_ReturnTrue()
        {
            // Arrange
            var unitUnderTest = CreateService();
            string bankName = "CUB";

            // Act
            var result = unitUnderTest.IsValidBankName(
                bankName);

            // Assert
            Assert.True(result, "CUB should be a valid bank name");
        }

        [Fact]
        public void GetARandomSerialNumber_MaxNumberIs500_ReturnNumberShouldInRange()
        {
            // Arrange
            var unitUnderTest = CreateService();
            int maxValue = 500;

            // Act
            var result = unitUnderTest.GetARandomSerialNumber(
                maxValue);

            // Assert
            Assert.InRange(result, 0, 500);
        }

        [Fact]
        public void MessageGen_SetNameAsMilse_ReturnMessageShouldContainMiles()
        {
            // Arrange
            var unitUnderTest = CreateService();
            string name = "Miles";

            // Act
            var result = unitUnderTest.MessageGen(
                name);

            // Assert
            Assert.Contains("Miles", result);
        }

        [Fact]
        public void GetOrders_GetAllOrder_ReturnThreeExpectedOrder()
        {
            // Arrange
            var unitUnderTest = CreateService();
            var expected = new[]
            {
                new { Id = 1, ItemName = "Shoes", Price= 2000 },
                new { Id = 2, ItemName = "Bag", Price= 500 },
                new { Id = 3, ItemName = "Wallet", Price= 180 }
            };

            // Act
            var result = unitUnderTest.GetOrders();

            // Assert
            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            expected.ToExpectedObject().ShouldMatch(okObjectResult.Value);
        }

        [Fact]
        public void IsValidPassword_PassNullPassword_ThrowArgumentNullException()
        {
            // Arrange
            var unitUnderTest = CreateService();
            string password = null;

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() =>
                unitUnderTest.IsValidPassword(password)
            );
        }
    }
}