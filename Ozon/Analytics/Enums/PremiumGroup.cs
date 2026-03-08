using System.Runtime.Serialization;

namespace Ozon.Analytics.Enums;

public enum PremiumGroup :int
{
    /// <summary>
    ///  Год
    /// </summary>
    [EnumMember(Value = "year")]
    Year,
    /// <summary>
    /// Категория первого уровня
    /// </summary>
    [EnumMember(Value = "category1")]
    Category1,
    /// <summary>
    /// Категория второго уровня
    /// </summary>
    [EnumMember(Value = "Category2")]
    Category2,
    /// <summary>
    /// Категория третьего уровня
    /// </summary>
    [EnumMember(Value = "category3")]
    Category3,
    /// <summary>
    /// Категория четвертого уровня
    /// </summary>
    [EnumMember(Value = "category4")]
    Category4,
    /// <summary>
    /// Бренд
    /// </summary>
    [EnumMember(Value = "brand")]
    Brand,
    /// <summary>
    /// Модель
    /// </summary>
    [EnumMember(Value = "modelID")]
    ModelID
}