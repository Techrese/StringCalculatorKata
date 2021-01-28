using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApplication.Dtos
{
    public class CalculationRequest
    {
        public string Input { get; set; }

        public string Operation { get; set; }
    }
}
