using Entities;

namespace Interactors.DataAccessInterfaces;
public interface IForecastFetcher
{
    IEnumerable<WeatherForecast> GetForecastByNumberOfDays(int numberOfDays);
}
