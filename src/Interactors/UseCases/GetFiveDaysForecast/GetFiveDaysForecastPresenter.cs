using Entities;

namespace Interactors.UseCases.GetFiveDaysForecast;
public sealed class GetFiveDaysForecastPresenter : IOutputPort
{
    public IEnumerable<WeatherForecast>? WeatherForecasts { get; private set; }

    public void Ok(IEnumerable<WeatherForecast> forecasts)
    {
        WeatherForecasts = forecasts;
    }
}
