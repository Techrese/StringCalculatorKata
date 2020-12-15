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
        
        [Test]
        public void WhenGivenInputOne_ShouldReturnOne()
        {
            string input = "1";

            int result = _calculator.Add(input);
            
            Assert.AreEqual(1, result);
        }

        [Test]
        public void WhenGivenInputTwo_ShouldReturnTwo()
        {
            string input = "2";

            int result = _calculator.Add(input);

            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void WhenGivenTwoInputs_ShouldReturnSum()
        {
            string input = "2,2";

            int result = _calculator.Add(input);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void WhenGivenAnyInputs_ShouldReturnSum()
        {
            string input = "2,2,2,2,2,2,2,2,2,2,2";

            int result = _calculator.Add(input);

            Assert.AreEqual(22, result);
        }
        
        [Test]
        public void WhenGivenAnyInputsSeparatedWithNewLines_ShouldReturnSum()
        {
            string input = "2\n2\n2\n2\n2\n2\n2\n2\n2\n2\n2";

            int result = _calculator.Add(input);

            Assert.AreEqual(22, result);
        }

        [Test]
        public void WhenGivenAnyInputsSeparatedWithAnySeperator_ShouldReturnSum()
        {
            string input = "2\n2,2\n2,2\n2,2\n2,2\n2,2";

            int result = _calculator.Add(input);

            Assert.AreEqual(22, result);
        }

        [Test]
        public void WhenGivenAnyInputsSeparatedWithDoubleSeperator_ShouldReturnSum()
        {
            string input = "2,\n";

            int result = _calculator.Add(input);

            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void WhenGivenAnyInputsWithSpecifiedDelimiter_ShouldReturnSum()
        {
            string input = "$\n2$2";

            int result = _calculator.Add(input);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void WhenGivenNegativeInput_ShouldThrowException()
        {
            string input = "-1";

            var exception = Assert.Catch(typeof(ArgumentException), () => { _calculator.Add(input); });
            Assert.AreEqual(exception.Message,"Negatives not allowed");
        }
    }
}