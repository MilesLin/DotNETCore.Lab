using DotNETCore.Lab.Lab7_DIP;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab7_DIP
{
    public class BonusAPITests
    {
        // �o�ӥi�H���β����A�d�U��
        [Fact]
        public void GetBonus_105Year_BonusTest()
        {
            // Arrange
            var unitUnderTest = new BonusAPI(new _105Bonus());
            int sells = 6;
            int expected = 5000;

            // Act
            var result = unitUnderTest.GetBonus(sells);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}