using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WhoAmIController : ControllerBase
    {

        [HttpGet(Name = "JoinGame")]
        public async Task<string> Get()
        {
            return Environment.MachineName;
        }
    }
}
