using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
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
        WeatherResults.Clear();
        var httpClient = new HttpClient();
        foreach (var result in await httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("http://localhost:5005/WeatherForecast"))
        {
            WeatherResults.Add(result);
        }
    }

    public ObservableCollection<object> WeatherResults { get; private set; } = new();
}

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
