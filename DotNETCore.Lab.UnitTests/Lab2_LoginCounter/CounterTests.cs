using DotNETCore.Lab.Lab2_LoginCounter;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab2_LoginCounter
{
    public class CounterTests
    {
        private Counter CreateCounter()
        {
            return new Counter();
        }

        [Fact]
        public void Add_PassOneToAddAndAddThreeTimes_CurrentCountShouldEqualThree()
        {
            // Arrange
            var unitUnderTest = CreateCounter();
            int i = 1;
            int exptected = 3;

            // Act
            unitUnderTest.Add(i);
            unitUnderTest.Add(i);
            unitUnderTest.Add(i);

            // Assert
            Assert.Equal(exptected, unitUnderTest.CurrentCount);
        }
    }
}
