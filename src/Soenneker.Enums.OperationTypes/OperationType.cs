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
    /// <summary>
    /// The equal.
    /// </summary>
    public static readonly OperatorType Equal = new(nameof(Equal));
    /// <summary>
    /// The not equal.
    /// </summary>
    public static readonly OperatorType NotEqual = new(nameof(NotEqual));

    /// <summary>
    /// The less than.
    /// </summary>
    public static readonly OperatorType LessThan = new(nameof(LessThan));
    /// <summary>
    /// The less than or equal.
    /// </summary>
    public static readonly OperatorType LessThanOrEqual = new(nameof(LessThanOrEqual));

    /// <summary>
    /// The greater than.
    /// </summary>
    public static readonly OperatorType GreaterThan = new(nameof(GreaterThan));
    /// <summary>
    /// The greater than or equal.
    /// </summary>
    public static readonly OperatorType GreaterThanOrEqual = new(nameof(GreaterThanOrEqual));

    /// <summary>
    /// The in.
    /// </summary>
    public static readonly OperatorType In = new(nameof(In));
    /// <summary>
    /// The not in.
    /// </summary>
    public static readonly OperatorType NotIn = new(nameof(NotIn));

    /// <summary>
    /// The contains.
    /// </summary>
    public static readonly OperatorType Contains = new(nameof(Contains));
    /// <summary>
    /// The starts with.
    /// </summary>
    public static readonly OperatorType StartsWith = new(nameof(StartsWith));
    /// <summary>
    /// The ends with.
    /// </summary>
    public static readonly OperatorType EndsWith = new(nameof(EndsWith));

    /// <summary>
    /// The exists.
    /// </summary>
    public static readonly OperatorType Exists = new(nameof(Exists));
}