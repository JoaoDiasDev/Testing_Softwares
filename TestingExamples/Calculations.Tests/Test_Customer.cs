using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class Test_Customer
    {
        private readonly Test_CustomerFixture _customerFixture;

        public Test_Customer(Test_CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        //[Fact]
        //public void CheckNameNotEmpty()
        //{
        //    var customer = new Customer();
        //    Assert.NotNull(customer.Name);
        //    Assert.False(string.IsNullOrEmpty(customer.Name));
        //}

        [Fact]
        public void CheckAgeForDiscount()
        {
            var customer = _customerFixture.Cust;
            Assert.InRange(customer.Age, 25, 40);
        }

        //[Fact]
        //public void GetOrdersByNameNotNull()
        //{
        //    var customer = new Customer();
        //    var execeptionDetails = Assert.Throws<ArgumentException>(()=> Customer.GetOrdersByName(""));
        //    Assert.Equal("Hello", execeptionDetails.Message);
        //}

        [Fact]
        public void LoyalCustomerForOrdersGreaterThan100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            //Assert.IsType(typeof(LoyalCustomer), customer);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
