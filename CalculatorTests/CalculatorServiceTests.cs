using CalculatorWebApplication.Services;
using NUnit.Framework;

namespace StringCalculatorKata
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        private CalculatorService _calculatorService = new();

        [SetUp]
        public void Setup()
        {
            _calculatorService = new();
        }

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

        [Test]
        public void WhenNoCalculationIsDone_ShouldReturnNull()
        {
            Assert.IsNull(_calculatorService.GetLatestCalculationResult());
        }

        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("5", ExpectedResult = 5)]
        [TestCase("1,2,3,4,5", ExpectedResult = 15)]
        public int? WhenCalculationWithResultIsCompleted_GetLatestCalculationResultShouldReturnSameResult(string input)
        {
            _calculatorService.Add(input);
            return _calculatorService.GetLatestCalculationResult();
        }
        
        [Test]
        public void WhenCalculationWithResultIsCompleted_GetLatestCalculationResultShouldReturnSameResult()
        {
            _calculatorService.Add("1,2");
            _calculatorService.Add("1,3");
            Assert.AreEqual(4, _calculatorService.GetLatestCalculationResult());
        }       

    }
}