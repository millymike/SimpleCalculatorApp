using CalculatorApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add/{num1}/{num2}")]
        public ActionResult<double> Add(double num1, double num2)
        {
            return _calculatorService.Add(num1, num2);
        }

        [HttpGet("subtract/{num1}/{num2}")]
        public ActionResult<double> Subtract(double num1, double num2)
        {
            return _calculatorService.Subtract(num1, num2);
        }

        [HttpGet("multiply/{num1}/{num2}")]
        public ActionResult<double> Multiply(double num1, double num2)
        {
            return _calculatorService.Multiply(num1, num2);
        }

        [HttpGet("divide/{num1}/{num2}")]
        public ActionResult<double> Divide(double num1, double num2)
        {
            return _calculatorService.Divide(num1, num2);
        }

    }
}