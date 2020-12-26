using CalculatorWebApplication.Services;
using NUnit.Framework;

namespace StringCalculatorKata
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculatorService = new();                      
        
        [Test]
        public void CalculatorService_ShouldReturnStatusTrue()
        {
            Assert.True(_calculatorService.GetStatus());
        }

        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("1,1", ExpectedResult = 2)]
        [TestCase("5", ExpectedResult = 5)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("1,2,3,4,5", ExpectedResult = 15)]
        public int When_Given_Input_Add_Should_Return_correctSum(string input)
        {
            return _calculatorService.Add(input);
        }

    }
}