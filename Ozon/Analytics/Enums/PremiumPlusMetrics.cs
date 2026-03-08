using System.Runtime.Serialization;

namespace Ozon.Analytics.Enums;

public enum PremiumPlusMetrics:int
{
    /// <summary>
    ///  Неизвестная метрика.
    /// </summary>
    [EnumMember(Value = "unknown_metric")]
    UnknownMetric,
    /// <summary>
    /// Показы в поиске и в категории.
    /// </summary>
    [EnumMember(Value = "hits_view_search")]
    HitsViewSearch, 
    /// <summary>
    /// Показы на карточке товара.
    /// </summary>
    [EnumMember(Value = "hits_view_pdp")]
    HitsViewPdp,
    /// <summary>
    /// Всего показов.
    /// </summary>
    [EnumMember(Value = "hits_view")]
    HitsView, 
    /// <summary>
    /// В корзину из поиска или категории.
    /// </summary>
    [EnumMember(Value = "hits_tocart_search")]
    HitsTocartSearch,
    /// <summary>
    /// В корзину из карточки товара.
    /// </summary>
    [EnumMember(Value = "hits_tocart_pdp")]
    HitsTocartPdp,
    /// <summary>
    /// Всего добавлено в корзину.
    /// </summary>
    [EnumMember(Value = "category1")]
    HitsTocart,
    /// <summary>
    /// Сессии с показом в поиске или в каталоге.<br/>Считаются уникальные посетители с просмотром в поиске или каталоге.
    /// </summary>
    [EnumMember(Value = "session_view_search")]
    SessionViewSearch, 
    /// <summary>
    /// Cессии с показом на карточке товара. Считаются уникальные посетители, которые просмотрели карточку товара.
    /// </summary>
    [EnumMember(Value = "session_view_pdp")]
    SessionViewPdp, 
    /// <summary>
    /// Всего сессий. Считаются уникальные посетители.
    /// </summary>
    [EnumMember(Value = "session_view")]
    SessionView, 
    /// <summary>
    /// Конверсия в корзину из поиска или категории.
    /// </summary>
    [EnumMember(Value = "conv_tocart_search")]
    ConvTocartSearch, 
    /// <summary>
    /// — конверсия в корзину из карточки товара.
    /// </summary>
    [EnumMember(Value = "conv_tocart_pdp")]
    ConvTocartPdp, 
    /// <summary>
    /// — общая конверсия в корзину.
    /// </summary>
    [EnumMember(Value = "conv_tocart")] 
    ConvTocart, 
    /// <summary>
    ///  Возвращено товаров.
    /// </summary>
    [EnumMember(Value = "returns")]
    Returns,
    /// <summary>
    /// Отменено товаров.
    /// </summary>
    [EnumMember(Value = "cancellations")]
    Cancellations,
    /// <summary>
    /// Доставлено товаров.
    /// </summary>
    [EnumMember(Value = "delivered_units")]
    DeliveredUnits,
    /// <summary>
    /// Позиция в поиске и категории.
    /// </summary>
    [EnumMember(Value = "position_category")]
    PositionCategory 
}