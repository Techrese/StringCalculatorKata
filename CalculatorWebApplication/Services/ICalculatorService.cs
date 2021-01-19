using System.Collections.Generic;
using CalculatorWebApplication.Models;

namespace CalculatorWebApplication.Services
{
    public interface ICalculatorService
    {
        bool GetStatus();
        
        int Add(string input);
        int Subtract(string input);
        int? GetLatestCalculationResult();
        Calculation GetLatestCalculationDetails();
        IEnumerable<int> GetCalculationResults();
    }
}