using System.Text.Json.Serialization;

namespace Ozon.Analytics.Entity;

/// <summary>
/// Уĸажите период и метриĸи, ĸоторые нужно посчитать. <br/>В ответе будет аналитиĸа, сгруппированная по параметру dimensions.
/// <seealso href="https://docs.ozon.ru/api/seller/#operation/AnalyticsAPI_AnalyticsGetData">Документация</seealso>
/// <typeparam name="required">ClientId</typeparam>
/// <typeparam name="required">ApiKey</typeparam>
/// <typeparam name="required">DateFrom</typeparam>
/// <typeparam name="required">DateTo</typeparam>
/// <typeparam name="required">Limit</typeparam>
/// </summary>
internal class Data
{
    /// <summary>
    /// Идентификатор клиента.
    /// <typeparam name="required"/>
    /// </summary>
    [JsonPropertyName("Client-Id")]
    internal string ClientId { get; set; } = string.Empty;
    /// <summary>
    /// API-ключ.
    /// <typeparam name="required"/>
    /// </summary>
    [JsonPropertyName("Api-Key")]
    internal string ApiKey { get; set; } = string.Empty;
    /// <summary>
    /// Дата, с которой будут данные в отчёте.<br/>
    /// Если у вас нет Premium-подписки, укажите дату в пределах последних трёх месяцев.
    /// <typeparam name="required"/>
    /// </summary>
    [JsonPropertyName("date_from")]
    internal string DateFrom { get; set; } = string.Empty;
    /// <summary>
    /// Дата, по которую будут данные в отчёте.
    /// <typeparam name="required"/>
    /// </summary>
    [JsonPropertyName("date_to")]
    internal string DateTo { get; set; } = string.Empty;
    /// <summary>
    /// Фильтры.
    /// <typeparam name="FilterData"><see cref="FilterData"/></typeparam>
    /// </summary>
    [JsonPropertyName("filters")]
    internal FilterData [] Filters { get; set; } = [];
    /// <summary>
    /// Количество значений в ответе:
    /// <br/>максимум — 1000,
    /// <br/>минимум — 1.
    /// </summary>
    [JsonPropertyName("limit")]
    internal int Limit { get; set; }
    /// <summary>
    /// Укажите до 14 метрик.<br/>Если их будет больше, вы получите ошибку с кодом
    /// </summary>
    [JsonPropertyName("metrics")]
    internal String [] Metrics { get; set; } =[]
}