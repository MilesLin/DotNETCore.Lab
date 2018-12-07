using DotNETCore.Lab.Lab5_TestAttribute;
using NSubstitute;
using System;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab5_TestAttribute
{
    public class DiscountServiceTests
    {


        public DiscountServiceTests()
        {

        }


        private DiscountService CreateService()
        {
            return new DiscountService();
        }

        [Trait("金額","計算價錢")]
        [Theory(DisplayName = "計算折扣")]
        [InlineData(100, Membership.Guest, 1, 95)]
        [InlineData(100, Membership.Common, 1, 90)]
        [InlineData(100, Membership.VIP, 1, 80)]
        [InlineData(100, Membership.Guest, 0.9, 85.5)]
        public void GetDiscountPrice_AllScenarioTests(
            decimal regularPrice, 
            Membership membership, 
            decimal eventDiscount,
            decimal expected)
        {
            // Arrange
            var unitUnderTest = CreateService();
            
            // Act
            var result = unitUnderTest.GetDiscountPrice(
                regularPrice,
                membership,
                eventDiscount);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact(Skip = "尚未實作")]
        public void SetupEvent_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateService();

            // Act
            unitUnderTest.SetupEvent();

            // Assert
            Assert.False(true);
        }
    }
}
