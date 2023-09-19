using ConsumirAPI.Models;

namespace ConsumirAPI.Service
{
    public interface ICountryApiService
    {
        Task<List<Country>> getCountry(string county);
    }
}
