using System.Runtime.Serialization;
namespace Ozon.Analytics.Enums;

public enum Order
{
    /// <summary>
    /// По возрастанию
    /// </summary>
    [EnumMember(Value = "DESC")]
    Asc ,
    /// <summary>
    ///  По убыванию.
    /// </summary>
    [EnumMember(Value = "DESC")]
    Desc
}