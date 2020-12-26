using NUnit.Framework;
using CalculatorWebApplication.Repositories;

namespace StringCalculatorKata
{
    [TestFixture]
    public class CalculatorRepositoryTests
    {
        private CalculatorRepository _calculatorRepository;

        [SetUp]
        public void Setup()
        {
            _calculatorRepository = new();
        }

        [Test]
        public void WhenNoCalculationIsDone_ShouldReturnNull()
        {
            Assert.IsNull(_calculatorRepository.GetLatestCalculationResult());
        }

        [TestCase(3, ExpectedResult = 3)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(15, ExpectedResult = 15)]
        public int? WhenCalculationWithResultIsCompleted_GetLatestCalculationResultShouldReturnSameResult(int input)
        {
            _calculatorRepository.AddCalculation(input);
            return _calculatorRepository.GetLatestCalculationResult();
        }

        [Test]
        public void WhenCalculationWithResultIsCompleted_GetLatestCalculationResultShouldReturnSameResult()
        {
            _calculatorRepository.AddCalculation(3);
            _calculatorRepository.AddCalculation(4);
            Assert.AreEqual(4, _calculatorRepository.GetLatestCalculationResult());
        }
    }
}
