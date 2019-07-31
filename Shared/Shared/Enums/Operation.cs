using System.ComponentModel;

namespace Shared.Enums
{
    public enum Operation
    {
        [Description("+")]
        Add,
        [Description("*")]
        Multiply,
        [Description("/")]
        Divide,
        [Description("-")]
        Subtract
    }
}
