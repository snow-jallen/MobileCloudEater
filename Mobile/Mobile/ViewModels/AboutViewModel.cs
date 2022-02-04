using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mobile.Services;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels;

public partial class AboutViewModel : ObservableObject
{
    private IApiService apiService;

    public AboutViewModel(IApiService apiService = null)
    {
        this.apiService = apiService ?? DependencyService.Get<IApiService>();
    }

    [ObservableProperty]
    private string desiredPlayerName;

    [ObservableProperty]
    private string result;

    [ICommand]
    public async Task JoinGame()
    {
        Result = await apiService.JoinGameAsync(DesiredPlayerName);
    }

}
