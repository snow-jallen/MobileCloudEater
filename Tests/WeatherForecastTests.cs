using NUnit.Framework;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    //[Test]
    //public async Task BasicConnection()
    //{
    //    var mock = new Mock<IWeatherService>();
    //    mock.Setup(m => m.GetForecastAsync())
    //        .ReturnsAsync(new[]
    //        {
    //            new WeatherForecast
    //            {
    //                Date = new DateTime(2022, 2, 4),
    //                Summary = "It's working!",
    //                TemperatureC = 25
    //            }
    //        });

    //    var aboutViewModel = new AboutViewModel(mock.Object);
    //    await aboutViewModel.GetWeatherCommand.ExecuteAsync(this);
    //    aboutViewModel.WeatherResults.Any().Should().BeTrue();
    //}
}
