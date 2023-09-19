using ConsumirAPI.Models;
using System.Text.Json;

namespace ConsumirAPI.Service
{
    public class HolidaysApiService : IHolidaysApiService
    {
        public async Task<List<Holidays>> getHolidays(string ISO2, int year, string type)
        {

            var url = $"https://api.api-ninjas.com/v1/holidays?country={ISO2}&year={year}&type={type}";

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-Api-Key", "/1y3Dx96hNtnFSnod6OyRA==HgDfBLgW9xmqOS1d");
                var respuesta = await httpClient.GetAsync(url);
                var respuestaString = await respuesta.Content.ReadAsStringAsync();
                var listadoEventos = JsonSerializer.Deserialize<List<Holidays>>(respuestaString,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                return listadoEventos;
            }
        }
    }
}
