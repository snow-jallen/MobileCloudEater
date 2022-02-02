using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mobile.ViewModels;

public partial class AboutViewModel : BaseViewModel
{
    public AboutViewModel()
    {
        Title = "About";
        OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
    }

    public ICommand OpenWebCommand { get; }


    [ICommand]
    public async Task GetWeather()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("http://localhost:5005/WeatherForecast");
    }

    public ObservableCollection<object> WeatherResults { get; private set; } = new();
}
