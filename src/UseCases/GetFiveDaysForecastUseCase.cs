using UseCases.Data;
using UseCases.Presenters;
using UseCases.Presenters.Vos;

namespace UseCases;
public class GetFiveDaysForecastUseCase : IGetFiveDaysForecastUseCase
{
    public GetFiveDaysForecastUseCase(
        IForecastFetcher forecastFetcher,
        IGetFiveDaysForecastPresenter weatherForecastPresenter)
    {
        this.forecastFetcher = forecastFetcher;
        this.weatherForecastPresenter = weatherForecastPresenter;
    }

    private readonly IForecastFetcher forecastFetcher;
    private readonly IGetFiveDaysForecastPresenter weatherForecastPresenter;

    public IPresenterResponse[] GetForecast()
    {
        var forecast = forecastFetcher.GetForecastByNumberOfDays(5);
        return weatherForecastPresenter.PresentForecast(forecast);
    }
}
