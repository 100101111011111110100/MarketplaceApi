using Ozon.Dto.Analytics;
namespace Ozon.Analytics.Interfaces;

public interface ISendAnalyticsData
{
    Task<AnalyticsResponse> SendAnalyticsData();
}