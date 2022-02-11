using Mobile.ViewModels;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task JoinGameSuccess()
    {
        var mock = new Mock<IApiService>();
        mock.Setup(m => m.JoinGame(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync("this is my token");

        var aboutViewModel = new AboutViewModel(mock.Object);
        await aboutViewModel.JoinGameCommand.ExecuteAsync(this);

        aboutViewModel.IsSignupVisible.Should().BeFalse();
        aboutViewModel.ArePlayControlsVisible.Should().BeTrue();
    }


    [Test]
    public async Task JoinGameFailure()
    {
        var mock = new Mock<IApiService>();
        mock.Setup(m => m.JoinGame(It.IsAny<string>(), It.IsAny<string>()))
            .Throws(new System.Exception("your api stinks"));

        var aboutViewModel = new AboutViewModel(mock.Object);
        await aboutViewModel.JoinGameCommand.ExecuteAsync(this);

        aboutViewModel.IsSignupVisible.Should().BeTrue();
        aboutViewModel.IsErrorVisible.Should().BeTrue();
        aboutViewModel.ErrorMessage.Should().Be("Unable to join game.");
    }
}
