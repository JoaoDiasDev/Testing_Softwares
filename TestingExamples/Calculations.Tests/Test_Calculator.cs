using System;
using Xunit;

namespace Calculations.Tests
{
    public class Test_Calculator
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);

        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.55);
            Assert.Equal(4.9, result, 0);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var calc = new Calculator();
            var result = calc.isOdd(1);
            //Assert.Equal(true, result);
            Assert.True(result);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsFalse()
        {
            var calc = new Calculator();
            var result = calc.isOdd(0);
            //Assert.Equal(false, result);
            Assert.False(result);
        }

        [Theory]
        [MemberData(nameof(Test_TestDataShare.IsOddOrEvenData), MemberType = typeof(Test_TestDataShare))]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.isOdd(value);
            Assert.True(expected);
        }

        [Theory]
        [MemberData(nameof(Test_TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(Test_TestDataShare))]
        public void IsOdd_TestOddAndEvenExternalData(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.isOdd(value);
            Assert.True(expected);

        }

        [Theory]
        //[MemberData(nameof(Test_TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(Test_TestDataShare))]
        [Test_IsOddOrEvenData]
        public void IsOdd_TestOddAndEvenDataAttribute(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.isOdd(value);
            Assert.True(expected);

        }
    }
}
