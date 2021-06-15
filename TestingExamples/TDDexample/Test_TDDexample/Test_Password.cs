using System;
using Xunit;
using TDDexample;

namespace Test_TDDexample
{
    public class Test_Password
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(7)+"A";
            var validationResult = testTarget.Validate(password);

            Assert.True(validationResult);
        }

        [Fact]
        public void Validate_GivenShorterThan8Characters_ReturnFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(6)+"A";
            var validationResult = testTarget.Validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void Validate_GivenNoUpperCase_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(8); // all lower-case
            var validationResult = testTarget.Validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void Validate_GivenOneUpperCase_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(8)+"A"; // at least one upper case
            var validationResult = testTarget.Validate(password);

            Assert.True(validationResult);
        }
        private string MakeString(int length)
        {
            string result = "";
            for (int i = 1; i <= length; i++)
            {
                result += "a";
            }
            return result;
        }
    }
}
