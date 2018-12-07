using DotNETCore.Lab.Lab3_InternalClass;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab3_InternalClass
{
    public class MyClassTests
    {


        public MyClassTests()
        {

        }


        private MyClass CreateMyClass()
        {
            return new MyClass();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = CreateMyClass();

            // Act
            var result = unitUnderTest.GetValue();

            // Assert
            Assert.NotNull(result);
        }

    }
}
