using CommunityToolkit.Mvvm.Input;
using Mobile.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mobile.ViewModels;

public partial class AboutViewModel : BaseViewModel
{
    private IWeatherService weatherService;

    public AboutViewModel(IWeatherService weatherService = null)
    {
        Title = "About";
        OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

        this.weatherService = weatherService ?? DependencyService.Get<IWeatherService>();
    }

    public ICommand OpenWebCommand { get; }


    [ICommand]
    public async Task GetWeather()
    {
        WeatherResults.Clear();
        foreach (var result in await weatherService.GetForecastAsync())
        {
            WeatherResults.Add(result);
        }
    }

    public ObservableCollection<object> WeatherResults { get; private set; } = new();
}
