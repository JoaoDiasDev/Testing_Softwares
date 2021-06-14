using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    [CollectionDefinition("Customer")]
    public class Test_CustomerFixtureCollection : ICollectionFixture<Test_CustomerFixture>
    {

    }
}
