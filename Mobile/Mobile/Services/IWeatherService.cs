using Mobile.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Mobile.Services
{
    public interface IWeatherService
    {

        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }

    public class WeatherForecastService : IWeatherService
    {
        private readonly HttpClient httpClient = new HttpClient();

        public Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            return httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("http://localhost:5005/WeatherForecast");
        }
    }
}
