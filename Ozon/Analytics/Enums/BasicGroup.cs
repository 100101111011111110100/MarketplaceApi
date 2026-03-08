using System.Runtime.Serialization;

namespace Ozon.Analytics.Enums;

public enum BasicGroup:int
{
    /// <summary>
    /// Неизвестное измерение
    /// </summary>
    [EnumMember(Value = "unknownDimension")]
    UnknownDimension ,
    /// <summary>
    /// Идентификатор товара,
    /// </summary>
    [EnumMember(Value = "sku")]
    Sku ,
    /// <summary>
    /// Идентификатор товара — объединённая карточка
    /// </summary>
    [EnumMember(Value = "spu")]
    Spu ,
    /// <summary>
    /// День
    /// </summary>
    [EnumMember(Value = "day")]
    Day,
    /// <summary>
    ///  Неделя
    /// </summary>
    [EnumMember(Value = "week")]
    Week,
    /// <summary>
    /// Месяц
    /// </summary>
    [EnumMember(Value = "month")]
    Month
}