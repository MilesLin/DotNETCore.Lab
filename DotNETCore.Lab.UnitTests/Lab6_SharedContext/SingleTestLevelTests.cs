using DotNETCore.Lab.Lab6_SharedContext;
using System;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab6_SharedContext
{
    public class SingleTestLevelTests : IDisposable
    {
        private string tableData;

        public SingleTestLevelTests()
        {
            tableData = "�s�W���";
        }


        private SingleTestLevel CreateSingleTestLevel()
        {
            return new SingleTestLevel();
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateSingleTestLevel();

            // Act
            var result = unitUnderTest.Get();

            // Assert
            Assert.False(false);
        }

        public void Dispose()
        {
            // �M�����
            tableData = null;
        }
    }
}
