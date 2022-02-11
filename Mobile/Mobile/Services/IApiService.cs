using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mobile.Services
{
    public interface IApiService
    {

        Task<string> JoinGameAsync(string playerName);
        Task<string> MoveDownAsync();
        Task<string> MoveRightAsync();
        Task<string> MoveUpAsync();
        Task<string> MoveLeftAsync();
    }

    public class RealApiService : IApiService
    {
        private readonly HttpClient httpClient = new HttpClient();
        private const string ServerUrl = "http://20.106.101.78";

        public async Task<string> JoinGameAsync(string playerName)
        {
            try
            {
                return await httpClient.GetStringAsync($"{ServerUrl}/join?name={playerName}");
            }
            catch (Exception ex)
            {
                throw new System.Exception();
            }
        }

        public async Task<string> MoveDownAsync()
        {
            try
            {
                return await httpClient.GetStringAsync($"{ServerUrl}/move?direction=down");
            }
            catch (Exception ex)
            {
                throw new System.Exception();
            }
        }

        public async Task<string> MoveLeftAsync()
        {
            return await httpClient.GetStringAsync($"{ServerUrl}/move?direction=left");
        }

        public async Task<string> MoveRightAsync()
        {
            return await httpClient.GetStringAsync($"{ServerUrl}/move?direction=right");
        }

        public async Task<string> MoveUpAsync()
        {
            return await httpClient.GetStringAsync($"{ServerUrl}/move?direction=up");
        }
    }
}
