using System.Text.Json.Serialization;

namespace Ozon.Analytics.Enums;

public enum BasicGroup:int
{
    /// <summary>
    /// Неизвестное измерение
    /// </summary>
    [JsonPropertyName("unknownDimension")]
    UnknownDimension ,
    /// <summary>
    /// Идентификатор товара,
    /// </summary>
    [JsonPropertyName("sku")]
    Sku ,
    /// <summary>
    /// Идентификатор товара — объединённая карточка
    /// </summary>
    [JsonPropertyName("spu")]
    Spu ,
    /// <summary>
    /// День
    /// </summary>
    [JsonPropertyName("day")]
    Day,
    /// <summary>
    ///  Неделя
    /// </summary>
    [JsonPropertyName("week")]
    Week,
    /// <summary>
    /// Месяц
    /// </summary>
    [JsonPropertyName("month")]
    Month
}