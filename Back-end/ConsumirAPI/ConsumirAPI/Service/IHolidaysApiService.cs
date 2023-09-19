using ConsumirAPI.Models;

namespace ConsumirAPI.Service
{
    public interface IHolidaysApiService
    {
        Task<List<Holidays>> getHolidays(string CA, int year, string type);
    }
}
