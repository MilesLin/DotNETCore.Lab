using DotNETCore.Lab.Lab6_SharedContext;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab6_SharedContext
{
    public class ClassLevelTests : IClassFixture<DataFixture>
    {
        private DataFixture _fixture;

        public ClassLevelTests(DataFixture fixture)
        {
            _fixture = fixture;
        }

        private ClassLevel CreateClassLevel()
        {
            return new ClassLevel();
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = CreateClassLevel();

            // Act
            var result = unitUnderTest.Get();

            // Assert
            Assert.False(false);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var unitUnderTest = CreateClassLevel();

            // Act
            var result = unitUnderTest.Get();

            // Assert
            Assert.False(false);
        }

    }
}
