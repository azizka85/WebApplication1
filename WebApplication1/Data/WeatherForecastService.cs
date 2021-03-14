using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class WeatherForecastService: IWeatherForecastService
    {
        private readonly HttpClient httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            return await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
