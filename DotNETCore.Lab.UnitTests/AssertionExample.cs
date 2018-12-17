using ExpectedObjects;
using System;
using System.Collections.Generic;
using Xunit;
using NSubstitute;

namespace DotNETCore.Lab.UnitTests
{
    public class AssertionExample
    {
        #region AssertEqual

        [Fact]
        public void AssertEqual_ValueDemo()
        {
            int a = 1;
            int b = 1;

            Assert.Equal(a, b);
        }

        [Fact]
        public void AssertEqual_ObjectDemo()
        {
            var p1 = new Phone { Brand = Brand.Apple };
            var p2 = new Phone { Brand = Brand.Apple };

            // 因為參考位址不一樣，所以會驗證失敗
            Assert.Equal(p1, p2);
        }

        [Fact]
        public void AssertEqual_DecimalDemo()
        {
            decimal a = 123.3211m;
            decimal b = 123.3215m;

            // Decimal(double) 可傳入精準度
            Assert.Equal(a, b, 2);
        }

        #endregion AssertEqual

        #region AssertTrueAndFalse

        [Fact]
        public void AssertTrue_Demo()
        {
            var result = true;

            Assert.True(result);
            //Assert.True(result, "測試失敗顯示的自定訊息");
            //Assert.False(result);

            /*
            禁止這樣做，因為會造成失敗訊息不明確
            */
            //string a = "Miles";
            //string b = "Grey";
            //Assert.True(a == b);
        }

        #endregion AssertTrueAndFalse

        #region AssertNullAndNotNull

        [Fact]
        public void AssertNullAndNotNull_Demo()
        {
            object result = null;

            Assert.Null(result);
            //Assert.NotNull(result);
        }

        #endregion AssertNullAndNotNull

        #region AssertInRangeAndNotRange

        [Fact]
        public void AssertInRangeAndNotRange_Demo()
        {
            int result = 10;

            Assert.InRange(result, 0, 10);
            //Assert.NotInRange(result, 0, 10);
        }

        #endregion AssertInRangeAndNotRange

        #region AssertContainersAndDoesNotContain

        [Fact]
        public void AssertContainersAndDoesNotContain_Demo()
        {
            var names = new[] { "Sarah", "Amrit" };

            Assert.Contains("Sarah", names);
            //Assert.DoesNotContain("Sarah", names);
        }

        #endregion AssertContainersAndDoesNotContain

        #region AssertThrowException

        [Fact]
        public void AssertThrowException_Demo()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() =>
                sut.Divide(10, 0)
            );

            // 可以取得 Exception 資訊，做更進一步的驗證
            //var ex = Assert.Throws<DivideByZeroException>(() =>
            //    sut.Divide(10, 0)
            //);
            //Assert.NotEmpty(ex.Message);
        }

        #endregion AssertThrowException

        #region AssertIsType

        [Fact]
        public void AssertIsType_Demo()
        {
            var p = new Phone();

            var phone = Assert.IsType<Phone>(p);
            //Assert.IsNotType<Phone>(p);
        }

        [Fact]
        public void AssertIsAssignalbeFrom_Demo()
        {
            var iPhone = new IPhone();

            // 驗證 IPhone 是 Phone 的子類別
            var phone = Assert.IsAssignableFrom<Phone>(iPhone);
        }

        #endregion AssertIsType

        #region ExpectedObjects

        [Fact]
        public void ExpectedObjects_SingleObj_Demo()
        {
            var expected = new Phone { Brand = Brand.Apple, Price = 399m }.ToExpectedObject();
            var result = new Phone { Brand = Brand.Apple, Price = 399m };

            expected.ShouldMatch(result);
        }

        [Fact]
        public void ExpectedObjects_SingleObjWithAnonymousType_Demo()
        {
            var expected = new { Brand = Brand.Apple, Price = 399m }.ToExpectedObject();
            var result = new Phone { Brand = Brand.Apple, Price = 399m };

            expected.ShouldMatch(result);
        }

        [Fact]
        public void ExpectedObjects_ListObj_Demo()
        {
            //arrange
            var expected = new[]
            {
                new { Brand = Brand.Apple, Price = 399m, Series = "X" },
                new { Brand = Brand.Sony, Price = 299m, Series = "Xperia" },
                new { Brand = Brand.Asus, Price = 100m, Series = "ZenPhone" }
            }.ToExpectedObject();

            var result = new List<Phone>
            {
                new Phone { Brand = Brand.Apple, Price = 399m, Series = "X" },
                new Phone { Brand = Brand.Asus, Price = 100m, Series = "ZenPhone" },
                new Phone { Brand = Brand.Sony, Price = 299m, Series = "Xperia" }
            };

            // 不比較順序
            expected.ShouldMatch(result);
        }

        [Fact]
        public void ExpectedObjects_ListObj_MatchOrder_Demo()
        {
            //arrange
            var expected = new[]
            {
                new { Brand = Brand.Sony, Price = 299m} ,
                new { Brand = Brand.Apple, Price = 399m },
                new { Brand = Brand.Asus, Price = 100m }
            }.ToExpectedObject(x => x.UseOrdinalComparison());

            var result = new List<Phone>
            {
                new Phone { Brand = Brand.Sony, Price = 299m, Series = "Xperia" },
                new Phone { Brand = Brand.Apple, Price = 399m, Series = "X" },
                new Phone { Brand = Brand.Asus, Price = 100m, Series = "ZenPhone" }
            };

            // 比較順序
            expected.ShouldMatch(result);
        }

        #endregion ExpectedObjects
    }

    #region Sample Code

    public class Calculator
    {
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

    public class Phone
    {
        public Brand Brand { get; set; }

        public string Series { get; set; }

        public decimal Price { get; set; }
    }

    public class IPhone : Phone
    {
        public int Resolution { get; set; }
    }

    public enum Brand
    {
        Apple,
        Sony,
        Asus
    }

    #endregion Sample Code
}