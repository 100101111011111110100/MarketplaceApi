using System.Text.Json.Serialization;

namespace Ozon.Dto.ErrorResponse;

public abstract class ApiError
{
    /// <summary>
    /// Код ошибки.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }
    /// <summary>
    /// Дополнительная информация об ошибке
    /// </summary>
    /// <typeparam name="Array of objects" ><see cref="AdditionalError"/></typeparam>
    [JsonPropertyName("details")]
    public AdditionalError[] Details { get; set; } = [];
    /// <summary>
    /// Описание ошибки
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}