using Entities;
using FluentAssertions;

namespace WeatherForecasting.Tests.EntitiesTest;
public class WeatherForecastTests
{
    [Theory]
    [InlineData(-23, -10)]
    [InlineData(-17, 0)]
    [InlineData(-10, 14)]
    [InlineData(0, 32)]
    [InlineData(30, 86)]
    public void WeatherForecast_Should_ConvertCelsiusToFahrenheit(int temperatureC, int temperatureF)
    {
        var weatherForecast = new WeatherForecast
        {
            TemperatureC = temperatureC
        };

        weatherForecast.TemperatureF.Should().BeCloseTo(temperatureF, 2);
    }
}
