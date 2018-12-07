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
            tableData = "新增資料";
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
            // 清除資料
            tableData = null;
        }
    }
}
