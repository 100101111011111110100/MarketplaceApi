using System.Text.Json.Serialization;

namespace Ozon.Dto.ErrorResponse;

public class AdditionalError
{
    /// <summary>
    /// Тип протокола передачи данных.
    /// </summary>
    [JsonPropertyName("typeUrl")]
    public string TypeUrl { get; set; } = string.Empty;
    /// <summary>
    /// Значение ошибки
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}