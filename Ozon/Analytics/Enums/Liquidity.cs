using System.Runtime.Serialization;
namespace Ozon.Analytics.Enums;

public enum Liquidity :int
{
    /// <summary>
    /// Нет статуса ликвидности.
    /// </summary>
    [EnumMember(Value = "TURNOVER_GRADE_NONE")]
    TurnoverGradeNone,
    /// <summary>
    /// Дефицитный. Остатков товара хватит до 28 дней.
    /// </summary>
    [EnumMember(Value = "DEFICIT")]
    Deficit,
    /// <summary>
    /// Очень популярный. Остатков товара хватит на 28–56 дней.
    /// </summary>
    [EnumMember(Value = "POPULAR")]
    Populare,
    /// <summary>
    /// Популярный. Остатков товара хватит на 56–120 дней.
    /// </summary>
    [EnumMember(Value = "ACTUAL")]
    Actual,
    /// <summary>
    /// Избыточный. Товар продаётся медленно, остатков хватит более чем на 120 дней.
    /// </summary>
    [EnumMember(Value = "SURPLUS")]
    Surplus,
    /// <summary>
    /// Без продаж. У товара нет продаж последние 28 дней.
    /// </summary>
    [EnumMember(Value = "NO_SALES")]
    NoSales,
    /// <summary>
    /// Был без продаж. У товара не было продаж и остатков последние 28 дней.
    /// </summary>
    [EnumMember(Value = "WAS_NO_SALES")]
    WasNoSales,
    /// <summary>
    /// Без продаж, ограничен. У товара не было продаж более 120 дней. Такой товар нельзя добавить в поставку.
    /// </summary>
    [EnumMember(Value = "RESTRICTED_NO_SALES")]
    RestrictedNoSales,
    /// <summary>
    /// Сбор данных. Для расчёта ликвидности нового товара собираем данные в течение 60 дней после поставки.
    /// </summary>
    [EnumMember(Value = "COLLECTING_DATA")]
    CollectingData,
    /// <summary>
    /// Ожидаем поставки. На складе нет остатков, доступных к продаже. Сделайте поставку для начала сбора данных.
    /// </summary>
    [EnumMember(Value = "WAITING_FOR_SUPPLY")]
    WaitingForSupply,
    /// <summary>
    /// Был дефицитным. Товар был дефицитным последние 56 дней. Сейчас у него нет остатков.
    /// </summary>
    [EnumMember(Value = "WAS_DEFICIT")]
    WasDefecit,
    /// <summary>
    /// Был очень популярным. Товар был очень популярным последние 56 дней. Сейчас у него нет остатков.
    /// </summary>
    [EnumMember(Value = "WAS_POPULAR")]
    WasPopular,
    /// <summary>
    /// Был популярным. Товар был популярным последние 56 дней. Сейчас у него нет остатков.
    /// </summary>
    [EnumMember(Value = "WAS_ACTUAL")]
    WasActual,
    /// <summary>
    /// Был избыточным. Товар был избыточным последние 56 дней. Сейчас у него нет остатков.
    /// </summary>
    [EnumMember(Value = "WAS_SURPLUS")]
    WasSurplus
}