using Interfces.CalculaeFunctions;
using Shared.Enums;

namespace Interfces
{
    public interface ICalculateOperationFactory
    {
        IBaseCalculateFunction GetCalculateFunction(Operation operations);
    }
}
