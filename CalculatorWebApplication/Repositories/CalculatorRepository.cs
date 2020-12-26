using CalculatorWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApplication.Repositories
{
    public class CalculatorRepository : ICalculatorRepository
    {          
        private IList<int> results = new List<int>();

        public void AddCalculation(int input)
        {                  
            results.Add(input);
        }

        public IEnumerable<Calculation> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> GetAllResults()
        {
            return results;
        }

        public Calculation GetLatestCalculation()
        {
            throw new NotImplementedException();
        }

        public int? GetLatestCalculationResult()
        {
            if (results.Count == 0)
            {
                return null;
            }
            return results.Last();
        }
    }
}
