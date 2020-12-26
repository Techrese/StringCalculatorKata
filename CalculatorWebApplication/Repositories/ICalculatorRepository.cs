using CalculatorWebApplication.Models;
using System.Collections.Generic;

namespace CalculatorWebApplication.Repositories
{
    public interface ICalculatorRepository
    {
        void AddCalculation(int input);
        Calculation GetLatestCalculation();

        int? GetLatestCalculationResult();

        IEnumerable<Calculation> GetAll();

        IEnumerable<int> GetAllResults();
    }
}
