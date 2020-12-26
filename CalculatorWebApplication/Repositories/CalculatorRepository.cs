using CalculatorWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApplication.Repositories
{
    public class CalculatorRepository : ICalculatorRepository
    {
        public void AddCalculation(int input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Calculation> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> GetAllResults()
        {
            throw new NotImplementedException();
        }

        public Calculation GetLatestCalculation()
        {
            throw new NotImplementedException();
        }

        public int GetLatestCalculationResult()
        {            
            throw new NotImplementedException();         
        }
    }
}
