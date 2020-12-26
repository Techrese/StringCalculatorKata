using System.Collections.Generic;

namespace CalculatorWebApplication.Services
{
    public interface ICalculatorService
    {
        bool GetStatus();
        
        int Add(string input);
        int Subtract(string input);
        int? GetLatestCalculationResult();
        int GetLatestCalculationDetails();
        IEnumerable<int> GetCalculationResults();
    }
}