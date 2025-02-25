using Intellenum;

namespace Soenneker.Enums.OperationTypes;

/// <summary>
/// An enumeration for common mathematical operations
/// </summary>
[Intellenum<string>]
public partial class OperatorType
{
    public static readonly OperatorType NotEqual = new(nameof(NotEqual));
    public static readonly OperatorType Equal = new(nameof(Equal));
    public static readonly OperatorType LessThan = new(nameof(LessThan));
    public static readonly OperatorType LessThanOrEqual = new(nameof(LessThanOrEqual));
    public static readonly OperatorType GreaterThan = new(nameof(GreaterThan));
    public static readonly OperatorType GreaterThanOrEqual = new(nameof(GreaterThanOrEqual));
    public static readonly OperatorType In = new(nameof(In));
    public static readonly OperatorType NotIn = new(nameof(NotIn));
}