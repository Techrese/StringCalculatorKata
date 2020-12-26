using CalculatorWebApplication.Repositories;
using CalculatorWebApplication.Services;
using NUnit.Framework;
using Moq;

namespace StringCalculatorKata
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        private Mock<ICalculatorRepository> _calculatorRepository = new Mock<ICalculatorRepository>();
        private CalculatorService _calculatorService;

        [SetUp]
        public void Setup()
        {
            _calculatorService = new(_calculatorRepository.Object);
            _calculatorRepository.Setup(repo => repo.GetLatestCalculationResult()).Returns((int?)null);
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
            int result = _calculatorService.Add(input);
            _calculatorRepository.Setup(repo => repo.GetLatestCalculationResult()).Returns(result);
            return _calculatorService.GetLatestCalculationResult();
        }
        
        [Test]
        public void WhenCalculationWithResultIsCompleted_GetLatestCalculationResultShouldReturnSameResult()
        {
            _calculatorRepository.Setup( repo => repo.GetLatestCalculationResult()).Returns(4);
            _calculatorService.Add("1,2");
            _calculatorService.Add("1,3");
            Assert.AreEqual(4, _calculatorService.GetLatestCalculationResult());
        } 
    }
}