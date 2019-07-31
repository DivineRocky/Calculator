using Interfces;
using Shared.Enums;

namespace Services.Calculators
{
    public class BaseCalculator
    {
        private readonly ICalculateOperationFactory calculateOperationFactory;

        public BaseCalculator(ICalculateOperationFactory calculateOperationFactory)
        {
            this.calculateOperationFactory = calculateOperationFactory;
        }

        public decimal Calculate(decimal firstNumber, decimal secondNumber, Operation operation)
        {
            var valculateFunction = calculateOperationFactory.GetCalculateFunction(operation);
            var reuslt = valculateFunction.Calculate(firstNumber, secondNumber);
            return reuslt;
        }
    }
}
