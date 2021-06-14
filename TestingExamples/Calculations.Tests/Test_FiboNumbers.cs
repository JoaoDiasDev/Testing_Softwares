using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{

    public class FiboNumbersFixture : IDisposable
    {
        public FiboNumbers Calc => new FiboNumbers();

        public void Dispose()
        {
            //Clean
        }
    }

    public class Test_FiboNumbers : IClassFixture<FiboNumbersFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly FiboNumbersFixture _fiboNumbersFixture;
        private readonly MemoryStream memoryStream;

        public Test_FiboNumbers(ITestOutputHelper testOutputHelper, FiboNumbersFixture fiboNumbersFixture)
        {
            _testOutputHelper = testOutputHelper;
            _fiboNumbersFixture = fiboNumbersFixture;
            _testOutputHelper.WriteLine("Constructor");

            memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category","Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("CheckFiboIsNotZero");
            var calc = _fiboNumbersFixture.Calc;
            //Assert.All(calc.Fibo, n => Assert.NotEqual(0, n));
            Assert.DoesNotContain(0, calc.Fibo);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            _testOutputHelper.WriteLine("Check13Exists");
            var calc = _fiboNumbersFixture.Calc;
            Assert.Contains(13, calc.Fibo);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            _testOutputHelper.WriteLine("CheckFiboDoesNotInclude4");
            var calc = _fiboNumbersFixture.Calc;
            Assert.DoesNotContain(4, calc.Fibo);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboCheckNumbers()
        {
            _testOutputHelper.WriteLine("CheckFiboNumbers");
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _fiboNumbersFixture.Calc;
            Assert.Equal(expectedCollection, calc.Fibo);
        }

        [Fact]
        public void Dispose()
        {
            memoryStream.Close();
        }
    }
}
