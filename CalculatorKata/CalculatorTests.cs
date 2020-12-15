using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorKata
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

        [Test]
        public void WhenGivenInputOne_ShouldReturnOne()
        {
            string input = "1";

            int result = _calculator.Add(input);

            Assert.AreEqual(1, result);
        }
    }
}
