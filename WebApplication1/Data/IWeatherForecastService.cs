using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}
