using System.Net.Http;
using System.Threading.Tasks;

namespace Mobile.Services
{
    public interface IApiService
    {

        Task<string> JoinGameAsync(string playerName);
    }

    public class RealApiService : IApiService
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<string> JoinGameAsync(string playerName)
        {
            return await httpClient.GetStringAsync($"http://localhost:5005/join?name={playerName}");
        }
    }
}
