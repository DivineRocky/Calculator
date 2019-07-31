using Interfces;
using Interfces.CalculaeFunctions;
using Services.Calculators;
using Shared.Enums;
using System;

namespace Services.Factories
{
    public class CalculateOperationFactory : ICalculateOperationFactory
    {
        public IBaseCalculateFunction GetCalculateFunction(Operation operations)
        {
            switch (operations)
            {
                case Operation.Add:
                    return new AddFunction();
                case Operation.Multiply:
                    return new MultiplyFunction();
                case Operation.Divide:
                    return new DivideFunction();
                case Operation.Subtract:
                    return new SubtractFunction();
            }
            throw new NotImplementedException();
        }
    }
}
