using System.Collections.Generic;

namespace CalculatorWebApplication.Services
{
    public class CalculatorService : ICalculatorService
    {
        public bool GetStatus()
        {
            return true;
        }

        public int Add(string input)
        {
            throw new System.NotImplementedException();
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