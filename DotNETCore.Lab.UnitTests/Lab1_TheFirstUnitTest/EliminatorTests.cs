using DotNETCore.Lab.Lab1_TheFirstUnitTest;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab1_TheFirstUnitTest
{
    public class EliminatorTests
    {


        public EliminatorTests()
        {

        }


        private Eliminator CreateEliminator()
        {
            return new Eliminator();
        }

        [Fact]
        public void EliminateSpace_StringHasSpaceAfterTheValue_ShuldReturnAStringWithoutSpace()
        {
            // Arrange
            var obj = new Employee
            {
                Id = 1,
                Name = "Miles  "
            };
            string expected = "Miles";
            var unitUnderTest = CreateEliminator();

            // Act
            var result = unitUnderTest.EliminateSpace(obj);

            // Assert
            Assert.Equal(expected, result.Name);
        }
    }
}
