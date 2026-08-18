using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.OperationTypes;

/// <summary>
/// Identifies a comparison or matching operator used to evaluate a filter condition.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class OperatorType
{
    /// <summary>
    /// The candidate value must equal the comparison value.
    /// </summary>
    public static readonly OperatorType Equal = new(nameof(Equal));
    /// <summary>
    /// The candidate value must not equal the comparison value.
    /// </summary>
    public static readonly OperatorType NotEqual = new(nameof(NotEqual));

    /// <summary>
    /// The candidate value must be less than the comparison value.
    /// </summary>
    public static readonly OperatorType LessThan = new(nameof(LessThan));
    /// <summary>
    /// The candidate value must be less than or equal to the comparison value.
    /// </summary>
    public static readonly OperatorType LessThanOrEqual = new(nameof(LessThanOrEqual));

    /// <summary>
    /// The candidate value must be greater than the comparison value.
    /// </summary>
    public static readonly OperatorType GreaterThan = new(nameof(GreaterThan));
    /// <summary>
    /// The candidate value must be greater than or equal to the comparison value.
    /// </summary>
    public static readonly OperatorType GreaterThanOrEqual = new(nameof(GreaterThanOrEqual));

    /// <summary>
    /// The candidate value must occur in the supplied set.
    /// </summary>
    public static readonly OperatorType In = new(nameof(In));
    /// <summary>
    /// The candidate value must not occur in the supplied set.
    /// </summary>
    public static readonly OperatorType NotIn = new(nameof(NotIn));

    /// <summary>
    /// The candidate value must contain the supplied value.
    /// </summary>
    public static readonly OperatorType Contains = new(nameof(Contains));
    /// <summary>
    /// The candidate value must begin with the supplied value.
    /// </summary>
    public static readonly OperatorType StartsWith = new(nameof(StartsWith));
    /// <summary>
    /// The candidate value must end with the supplied value.
    /// </summary>
    public static readonly OperatorType EndsWith = new(nameof(EndsWith));

    /// <summary>
    /// The candidate field or value must exist.
    /// </summary>
    public static readonly OperatorType Exists = new(nameof(Exists));
}
