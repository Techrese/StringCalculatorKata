using System;
using NUnit.Framework;

namespace StringCalculatorKata
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator = new Calculator();

        [Test]
        public void WhenGivenEmptyString_ShouldReturnZero()
        {
            string input = string.Empty;

            int result = _calculator.Add(input);
            
            Assert.AreEqual(0, result);
        }
    }
}