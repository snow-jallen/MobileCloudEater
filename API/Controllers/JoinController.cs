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
        private readonly IConfiguration config;

        public JoinController(ILogger<WeatherForecastController> logger, HttpClient httpClient, IStateService state, IConfiguration config)
        {
            _logger = logger;
            this.httpClient = httpClient;
            this.state = state;
            this.config = config;
        }

        [HttpGet(Name = "JoinGame")]
        public async Task<string> Get(string name, string appPassword)
        {
            if (appPassword != config["appPassword"])
            {
                throw new Exception("Bad app password");
            }
            state.Token = await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/join?playerName={name}");
            return "Congrats!";
        }
    }
}