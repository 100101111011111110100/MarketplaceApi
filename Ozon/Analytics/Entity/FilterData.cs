using System.Text.Json.Serialization;
using Ozon.Analytics.Enums;
namespace Ozon.Analytics.Entity;

internal class FilterData
{
    /// <summary>
    /// Параметр сортировки.
    /// Можно передать любой атрибут из параметров BasicGroup,PremiumGroup, и metric, кроме атрибута brand
    /// </summary>
    [JsonPropertyName("key")] 
    internal string Key { get;} = string.Empty;
    /// <summary>
    /// Default: "EQ"
    /// Операция сравнения
    /// <seealso cref="Comparsion"/>
    /// </summary>
    [JsonPropertyName("op")]
    internal string Op { get; } = "EQ";
    /// <summary>
    /// Значение для сравнения.
    /// </summary>
    [JsonPropertyName("value")]
    internal string Value { get; set; } = string.Empty;
}