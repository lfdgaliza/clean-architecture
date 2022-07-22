using Entities;
using UseCases.Presenters.Vos;

namespace UseCases.Presenters;
public interface IGetFiveDaysForecastPresenter
{
    public IPresenterResponse[] PresentForecast(IEnumerable<WeatherForecast> forecast);
}
