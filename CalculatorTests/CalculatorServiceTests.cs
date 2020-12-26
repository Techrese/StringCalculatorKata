using CalculatorWebApplication.Services;
using NUnit.Framework;

namespace StringCalculatorKata
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        private CalculatorService _calculatorService = new();
        
        [Test]
        public void CalculatorService_ShouldReturnStatusTrue()
        {
            Assert.True(_calculatorService.GetStatus());
        }
    }
}