using System.Runtime.Serialization;
namespace Ozon.Analytics.Enums;

public enum Comparsion :int
{
    /// <summary>
    /// Равно
    /// </summary>
    [EnumMember(Value = "EQ")]
    Eq,
    /// <summary>
    /// Больше
    /// </summary>
    [EnumMember(Value = "GT")]
    Gt,
    /// <summary>
    /// Больше или равно
    /// </summary>
    [EnumMember(Value = "GTE")]
    Gte,
    /// <summary>
    /// Меньше
    /// </summary>
    [EnumMember(Value = "LT")]
    Lt,
    /// <summary>
    /// Меньше или равно.
    /// </summary>
    [EnumMember(Value = "LT")]
    Lte 
}