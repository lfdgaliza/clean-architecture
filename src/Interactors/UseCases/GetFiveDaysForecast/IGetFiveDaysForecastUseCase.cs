namespace Interactors.UseCases.GetFiveDaysForecast;

public interface IGetFiveDaysForecastUseCase
{
    void SetOutputPort(IOutputPort outputPort);

    void Execute();
}