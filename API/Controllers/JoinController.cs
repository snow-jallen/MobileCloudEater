using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JoinController : ControllerBase
    {
        private ILogger<WeatherForecastController> _logger;
        private readonly HttpClient httpClient;
        private readonly IStateService state;

        public JoinController(ILogger<WeatherForecastController> logger, HttpClient httpClient, IStateService state)
        {
            _logger = logger;
            this.httpClient = httpClient;
            this.state = state;
        }

        [HttpGet(Name = "JoinGame")]
        public async Task<string> Get(string name)
        {
            state.Token = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/join?playerName={name}");
            return "Congrats!";
        }
    }
}