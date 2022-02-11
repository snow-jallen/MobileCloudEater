using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoveController : ControllerBase
    {
        private readonly IStateService stateService;
        private readonly HttpClient httpClient;

        public MoveController(IStateService stateService, HttpClient httpClient)
        {
            this.stateService = stateService;
            this.httpClient = httpClient;
        }

        [HttpGet(Name = "Move")]
        public async Task<string> Get(string direction)
        {
            return await httpClient.GetStringAsync($"https://hungrygame.azurewebsites.net/move/{direction}?token={stateService.Token}");

        }
    }
}
