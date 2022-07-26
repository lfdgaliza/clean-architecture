using Entities;

namespace Api.UseCases.GetFiveDaysForecast;

public record GetFiveDaysForecastResponse(List<WeatherForecastModel> WeatherForecasts)
{
    public GetFiveDaysForecastResponse(IEnumerable<WeatherForecast> forecasts)
        : this(forecasts.Select(f => new WeatherForecastModel(f)).ToList())
    {
    }
}
