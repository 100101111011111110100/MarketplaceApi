using System.Text.Json.Serialization;

namespace Ozon.Analytics.Enums;

public enum PremiumGroup :int
{
    /// <summary>
    ///  Год
    /// </summary>
    [JsonPropertyName("year")]
    Year,
    /// <summary>
    /// Категория первого уровня
    /// </summary>
    [JsonPropertyName("category1")]
    Category1,
    /// <summary>
    /// Категория второго уровня
    /// </summary>
    [JsonPropertyName("")]
    Category2,
    /// <summary>
    /// Категория третьего уровня
    /// </summary>
    [JsonPropertyName("category3")]
    Category3,
    /// <summary>
    /// Категория четвертого уровня
    /// </summary>
    [JsonPropertyName("category4")]
    Category4,
    /// <summary>
    /// Бренд
    /// </summary>
    [JsonPropertyName("brand")]
    Brand,
    /// <summary>
    /// Модель
    /// </summary>
    [JsonPropertyName("modelID")]
    ModelID
}