using DotNETCore.Lab.Lab9_TDD;
using NSubstitute;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab9_TDD
{
    public class YearBonusAPITests
    {
        private IEmployeeRepo _employee;
        private IAccountingRepo _account;

        private YearBonusAPI CreateYearBonusAPI()
        {
            _employee = Substitute.For<IEmployeeRepo>();
            _account = Substitute.For<IAccountingRepo>();

            return new YearBonusAPI(_employee, _account);
        }

        [Theory]
        [InlineData(Department.恨瞶场, Position.戮单, 30000, 49500)]
        [InlineData(Department.恨瞶场, Position.戮单, 40000, 69000)]
        public void GetYearBonusTest(
            Department department,
            Position position,
            decimal salary,
            decimal expected
            )
        {
            // Arrange
            var unitUnderTest = this.CreateYearBonusAPI();
            _employee.GetEmployeeInfo(5).ReturnsForAnyArgs(
                new EmployeeInfo
                {
                    Id = 5,
                    Name = "Miles",
                    Department = department,
                    Position = position
                });
            _account.GetSalary(5).ReturnsForAnyArgs(salary);

            // Act
            BonusVM result = unitUnderTest.GetYearsBonus(id: 5);

            // Assert
            Assert.Equal(5, result.Id);
            Assert.Equal("Miles", result.Name);
            Assert.Equal(expected, result.YearBonus);
        }
    }
}