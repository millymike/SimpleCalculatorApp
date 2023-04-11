using CalculatorApi.Models;


namespace CalculatorApi.Services

{
    public class CalculatorService : ICalculatorService
    {
        private readonly Calculator _calculator;

        public CalculatorService()
        {
            _calculator = new Calculator();
        }

        public double Add(double num1, double num2)
        {
            return _calculator.Add(num1, num2);
        }

        public double Subtract(double num1, double num2)
        {
            return _calculator.Subtract(num1, num2);
        }

        public double Multiply(double num1, double num2)
        {
            return _calculator.Multiply(num1, num2);
        }

        public double Divide(double num1, double num2)
        {
            return _calculator.Divide(num1, num2);
        }
    }
}