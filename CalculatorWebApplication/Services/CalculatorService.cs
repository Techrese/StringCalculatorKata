using System.Collections.Generic;
using CalculatorWebApplication.Models;

namespace CalculatorWebApplication.Services
{
    public class CalculatorService : ICalculatorService
    {
        private Calculator _calculator = new();
        private int latestCalculation;
        private bool currentStatus;

        public bool GetStatus()
        {
            currentStatus = true;
            return currentStatus;
        }

        public int Add(string input)
        {
            latestCalculation = _calculator.Add(input);
            currentStatus = true;
            return latestCalculation;
        }

        public int Subtract(string input)
        {
            throw new System.NotImplementedException();
        }

        public int? GetLatestCalculationResult()
        {
            if (!currentStatus)
            {
                return null;
            }
            return latestCalculation;
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