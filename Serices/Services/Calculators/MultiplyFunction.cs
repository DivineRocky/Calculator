using Interfces.CalculaeFunctions;

namespace Services.Calculators
{
    public class MultiplyFunction : IBaseCalculateFunction
    {
        public decimal Calculate(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
