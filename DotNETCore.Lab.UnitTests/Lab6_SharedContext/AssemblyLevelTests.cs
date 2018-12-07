using DotNETCore.Lab.Lab6_SharedContext;
using NSubstitute;
using System;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab6_SharedContext
{
    [Collection(CollecitonKey.DataCollection)]
    public class AssemblyLevelTests
    {

        private DataFixture _fixture;

        public AssemblyLevelTests(DataFixture fixture)
        {
            _fixture = fixture;
        }

        private AssemblyLevel CreateAssemblyLevel()
        {
            return new AssemblyLevel();
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateAssemblyLevel();

            // Act
            var result = unitUnderTest.Get();

            // Assert
            Assert.False(false);
        }
    }
}
