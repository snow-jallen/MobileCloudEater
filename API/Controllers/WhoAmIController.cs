using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WhoAmIController : ControllerBase
    {

        [HttpGet(Name = "WhoAmI")]
        public async Task<string> Get()
        {
            return $"It is {DateTime.Now} and I'm running on {Environment.MachineName}.";
        }
    }
}
