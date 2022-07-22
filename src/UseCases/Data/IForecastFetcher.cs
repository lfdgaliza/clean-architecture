using Entities;

namespace UseCases.Data;
public interface IForecastFetcher
{
    IEnumerable<WeatherForecast> GetForecastByNumberOfDays(int numberOfDays);
}
