using ConsumirAPI.Models;
using System.Text.Json;

namespace ConsumirAPI.Service
{
    public class CountryApiService : ICountryApiService
    {
        public async Task<List<Country>> getCountry(string county)
        {
            var url = $"https://api.api-ninjas.com/v1/country?name={county}";
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-Api-Key", "/1y3Dx96hNtnFSnod6OyRA==HgDfBLgW9xmqOS1d");
                var respuesta = await httpClient.GetAsync(url);
                var respuestaString = await respuesta.Content.ReadAsStringAsync();
                var listadoEventos = JsonSerializer.Deserialize<List<Country>>(respuestaString,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                return listadoEventos;
            }
        }
    }
}
