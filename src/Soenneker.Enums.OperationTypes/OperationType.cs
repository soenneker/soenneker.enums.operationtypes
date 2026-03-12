using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.OperationTypes;

/// <summary>
/// An enumeration for common data operations
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class OperatorType
{
    public static readonly OperatorType Equal = new(nameof(Equal));
    public static readonly OperatorType NotEqual = new(nameof(NotEqual));

    public static readonly OperatorType LessThan = new(nameof(LessThan));
    public static readonly OperatorType LessThanOrEqual = new(nameof(LessThanOrEqual));

    public static readonly OperatorType GreaterThan = new(nameof(GreaterThan));
    public static readonly OperatorType GreaterThanOrEqual = new(nameof(GreaterThanOrEqual));

    public static readonly OperatorType In = new(nameof(In));
    public static readonly OperatorType NotIn = new(nameof(NotIn));

    public static readonly OperatorType Contains = new(nameof(Contains));
    public static readonly OperatorType StartsWith = new(nameof(StartsWith));
    public static readonly OperatorType EndsWith = new(nameof(EndsWith));

    public static readonly OperatorType Exists = new(nameof(Exists));
}