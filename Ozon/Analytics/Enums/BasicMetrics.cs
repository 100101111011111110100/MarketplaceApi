using System.Runtime.Serialization;
namespace Ozon.Analytics.Enums;

public enum BasicMetrics:int
{
    /// <summary>
    ///  Заказано на сумму
    /// </summary>
    [EnumMember(Value = "revenue")]
    Revenue,
    /// <summary>
    /// Заказано товаров.
    /// </summary>
    [EnumMember(Value = "ordered_units")]
    OrderedUnits 
}