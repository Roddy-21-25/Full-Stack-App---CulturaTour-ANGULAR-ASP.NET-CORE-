using ConsumirAPI.Models;

namespace ConsumirAPI.Service
{
    public interface IHistoricalEventsApiService
    {
        Task<List<HistoricalEvents>> getHistoricalEvents(string county);
    }
}
