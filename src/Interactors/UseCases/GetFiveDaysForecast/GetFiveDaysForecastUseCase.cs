using Interactors.DataAccessInterfaces;

namespace Interactors.UseCases.GetFiveDaysForecast;
public class GetFiveDaysForecastUseCase : IGetFiveDaysForecastUseCase
{
    private readonly IForecastFetcher forecastFetcher;
    private IOutputPort? outputPort;

    public GetFiveDaysForecastUseCase(IForecastFetcher forecastFetcher)
    {
        this.forecastFetcher = forecastFetcher;
        this.outputPort = new GetFiveDaysForecastPresenter();
    }

    public void SetOutputPort(IOutputPort outputPort)
    {
        this.outputPort = outputPort;
    }

    public void Execute()
    {
        var forecastEntities = this.forecastFetcher.GetForecastByNumberOfDays(5);

        this.outputPort?.Ok(forecastEntities);
    }
}
