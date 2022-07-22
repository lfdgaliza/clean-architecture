using UseCases.Presenters.Vos;

namespace UseCases;

public interface IGetFiveDaysForecastUseCase
{
    IPresenterResponse[] GetForecast();
}