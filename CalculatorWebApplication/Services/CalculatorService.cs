using System.Collections.Generic;
using CalculatorWebApplication.Models;
using CalculatorWebApplication.Repositories;

namespace CalculatorWebApplication.Services
{
    public class CalculatorService : ICalculatorService
    {
        private Calculator _calculator = new();
        private ICalculatorRepository _calculatorRepository;


        public CalculatorService(ICalculatorRepository calculatorRepository)
        {
            _calculatorRepository = calculatorRepository;
        }

        public bool GetStatus()
        {            
            return true;
        }

        public int Add(string input)
        {            
            int latestCalculation = _calculator.Add(input);
            _calculatorRepository.AddCalculation(latestCalculation);
            return latestCalculation;
        }

        public int Subtract(string input)
        {
            throw new System.NotImplementedException();
        }

        public int? GetLatestCalculationResult()
        {
            return _calculatorRepository.GetLatestCalculationResult();
        }

        public Calculation GetLatestCalculationDetails()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<int> GetCalculationResults()
        {
            throw new System.NotImplementedException();
        }
    }
}