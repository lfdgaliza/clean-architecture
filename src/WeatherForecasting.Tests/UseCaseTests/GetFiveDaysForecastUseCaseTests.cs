using Entities;
using FluentAssertions;
using UseCases;
using UseCases.Data;
using UseCases.Presenters;
using UseCases.Presenters.Vos;

namespace WeatherForecasting.Tests.UseCaseTests;

public class GetFiveDaysForecastUseCaseTests
{
    [Fact]
    public void GetFiveDaysForecastUseCase_Should_ReturnForecastForFiveDays()
    {
        var useCase = new GetFiveDaysForecastUseCase(new ForecastFetcher(), new WeatherForecastPresenter());
        useCase.GetForecast().Length.Should().Be(5);
    }
}

class ForecastFetcher : IForecastFetcher
{
    public IEnumerable<WeatherForecast> GetForecastByNumberOfDays(int numberOfDays)
    {
        for (var i = 0; i < numberOfDays; i++)
        {
            yield return new WeatherForecast();
        }
    }
}

record Response() : IPresenterResponse;

class WeatherForecastPresenter : IGetFiveDaysForecastPresenter
{
    public IPresenterResponse[] PresentForecast(IEnumerable<WeatherForecast> forecast)
    {
        return forecast.Select(f => new Response()).ToArray();
    }
}