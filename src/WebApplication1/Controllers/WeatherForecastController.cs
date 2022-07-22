using ApiPresenters;
using Microsoft.AspNetCore.Mvc;
using UseCases;
using UseCases.Presenters.Vos;

namespace Api.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IGetFiveDaysForecastUseCase getFiveDaysForecastUseCase;

    public WeatherForecastController(IGetFiveDaysForecastUseCase getFiveDaysForecastUseCase)
    {
        this.getFiveDaysForecastUseCase = getFiveDaysForecastUseCase;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IPresenterResponse[] GetForecast()
    {
        return getFiveDaysForecastUseCase.GetForecast().Cast<ForecastResponse>().ToArray();
    }
}
