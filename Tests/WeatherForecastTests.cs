using FluentAssertions;
using Mobile.ViewModels;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task BasicConnection()
        {
            var aboutViewModel = new AboutViewModel();
            await aboutViewModel.GetWeatherCommand.ExecuteAsync(this);
            aboutViewModel.WeatherResults.Any().Should().BeTrue();
        }
    }
}