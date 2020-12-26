using System.Collections.Generic;
using CalculatorWebApplication.Models;

namespace CalculatorWebApplication.Services
{
    public class CalculatorService : ICalculatorService
    {
        private Calculator _calculator = new();
        public bool GetStatus()
        {
            return true;
        }

        public int Add(string input)
        {
            return _calculator.Add(input);
        }

        public int Subtract(string input)
        {
            throw new System.NotImplementedException();
        }

        public int GetLatestCalculationResult()
        {
            throw new System.NotImplementedException();
        }

        public int GetLatestCalculationDetails()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<int> GetCalculationResults()
        {
            throw new System.NotImplementedException();
        }
    }
}