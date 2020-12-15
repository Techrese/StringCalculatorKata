using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit;
using NUnit.Framework;

namespace StringCalculatorKata
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator = new Calculator();

        [Test]
        public void WhenGivenEmptyString_ReturnZero()
        {
            string input = string.Empty;

            int result = calculator.Add(input);
            Assert.AreEqual(0,result);
        }
    }
}
