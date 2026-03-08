using System.Text.Json.Serialization;
using Ozon.Analytics.Enums;
namespace Ozon.Analytics.Entity;

internal class SortData
{
    /// <summary>
    /// Метрика, по которой будет отсортирован результат запроса.
    /// </summary>
    [JsonPropertyName("key")]
    internal string Key { get; set; }=string.Empty;
    /// <summary>
    /// Вид сортировки
    /// <seealso cref="Enums.Order"/>
    /// </summary>
    [JsonPropertyName("order")]
    internal string Order { get; }
}