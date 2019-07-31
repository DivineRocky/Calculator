using Interfces.CalculaeFunctions;

namespace Services.Calculators
{
    public class SubtractFunction : IBaseCalculateFunction
    {
        public decimal Calculate(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
