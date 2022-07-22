using Entities;
using UseCases.Presenters;
using UseCases.Presenters.Vos;

namespace ApiPresenters;
public class WeatherForecastPresenter : IGetFiveDaysForecastPresenter
{
    public IPresenterResponse[] PresentForecast(IEnumerable<WeatherForecast> forecast)
    {
        return TransformResponse(forecast).ToArray();
    }

    private IEnumerable<IPresenterResponse> TransformResponse(IEnumerable<WeatherForecast> forecast)
    {
        foreach (var forecastItem in forecast)
        {
            yield return new ForecastResponse(
                forecastItem.Date,
                forecastItem.TemperatureC,
                forecastItem.TemperatureF,
                forecastItem.Summary ?? string.Empty);
        }
    }
}
