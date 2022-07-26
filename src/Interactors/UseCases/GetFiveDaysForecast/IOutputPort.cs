using Entities;

namespace Interactors.UseCases.GetFiveDaysForecast;
public interface IOutputPort
{
    /// <summary>
    /// Five days forecast listed
    /// </summary>
    void Ok(IEnumerable<WeatherForecast> forecasts);
}
