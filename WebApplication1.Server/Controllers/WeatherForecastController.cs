using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

using WebApplication1.Data;

namespace WebApplication1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            this.weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await weatherForecastService.GetForecastAsync();
        }
    }
}
