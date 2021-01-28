using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CalculatorWebApplication.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorWebApplication.Models;
using CalculatorWebApplication.Services;

namespace CalculatorWebApplication.Controllers
{
    public class CalculationController : Controller
    {
        private readonly ILogger<CalculationController> _logger;
        private ICalculatorService _calculatorService;

        public CalculationController(ILogger<CalculationController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        [Route("/calculation")]
        [HttpPost]
        public JsonResult Index([FromBody] CalculationRequest calculationRequest)
        {
            var calculationResponse = new CalculationResponse();
            if (calculationRequest.Operation.Equals("add", StringComparison.OrdinalIgnoreCase))
            {
                calculationResponse.CalculationResult = _calculatorService.Add(calculationRequest.Input).ToString();
            }
            
            return Json(calculationResponse);
        }
    }
}