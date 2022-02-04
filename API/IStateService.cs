namespace API
{
    public interface IStateService
    {
        public string Token { get; set; }
    }

    public class StateService : IStateService
    {
        public string Token { get; set; }
    }
}
