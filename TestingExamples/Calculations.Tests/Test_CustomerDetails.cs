using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class Test_CustomerDetails
    {
        private readonly Test_CustomerFixture _customerFixture;

        public Test_CustomerDetails(Test_CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.Cust;
            Assert.Equal("Joao Dias", customer.GetFullName("Joao", "Dias"));
        }
    }
}
