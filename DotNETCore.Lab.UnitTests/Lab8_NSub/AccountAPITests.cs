using DotNETCore.Lab.Lab8_NSub;
using NSubstitute;
using System;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab8_NSub
{
    public class AccountAPITests
    {
        private IAccountRepo subAccountRepo;
        private ILogger subLogger;

        public AccountAPITests()
        {
            this.subAccountRepo = Substitute.For<IAccountRepo>();
            this.subLogger = Substitute.For<ILogger>();
        }

        private AccountAPI CreateAccountAPI()
        {
            return new AccountAPI(
                this.subAccountRepo,
                this.subLogger);
        }

        [Fact]
        public void CreateANewAccount_AccoutExists_ReturnAccountExist()
        {
            // Arrange
            var unitUnderTest = this.CreateAccountAPI();
            string id = "A123456789";
            subAccountRepo.IsExist(Arg.Any<string>()).Returns(true);

            string expected = "此身分證已建立過帳號";

            // Act
            var result = unitUnderTest.CreateANewAccount(
                id);

            // Assert
            Assert.Equal(expected, result);
            subAccountRepo.DidNotReceive().Create(Arg.Any<string>());
        }

        [Fact]
        public void CreateANewAccount_NewAccount_ReturnAccountCreated()
        {
            // Arrange
            var unitUnderTest = this.CreateAccountAPI();
            string id = "A123456789";
            subAccountRepo.IsExist(Arg.Any<string>()).Returns(false);

            string expected = "帳號建立完成";

            // Act
            var result = unitUnderTest.CreateANewAccount(
                id);

            // Assert
            Assert.Equal(expected, result);
            subAccountRepo.Received().Create(Arg.Any<string>());
        }

        [Fact]
        public void CreateANewAccount_CreateFailed_ReturnSystemError()
        {
            // Arrange
            var unitUnderTest = this.CreateAccountAPI();
            string id = "A123456789";
            subAccountRepo.IsExist(Arg.Any<string>()).Returns(false);
            subAccountRepo
                .When(x => x.Create(Arg.Any<string>()))
                .Do(x => throw new Exception());

            string expected = "系統發生錯誤";

            // Act
            var result = unitUnderTest.CreateANewAccount(
                id);

            // Assert
            Assert.Equal(expected, result);
            subLogger.Received().Error(Arg.Any<Exception>());
        }
    }
}