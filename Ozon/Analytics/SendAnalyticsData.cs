using Ozon.Analytics.Interfaces;
using Ozon.Dto.Analytics;

namespace Ozon.Analytics;

public class SendAnalyticsData :ISendAnalyticsData
{
    Task<AnalyticsResponse> SendAnalyticsData();
}