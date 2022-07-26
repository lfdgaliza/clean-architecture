using Entities;
using Interactors.UseCases.GetFiveDaysForecast;
using Microsoft.AspNetCore.Mvc;

namespace Api.UseCases.GetFiveDaysForecast;
[ApiController]
[Route("[controller]")]
public sealed class WeatherForecastController : ControllerBase, IOutputPort
{
    private readonly IGetFiveDaysForecastUseCase useCase;
    private IActionResult? viewModel;

    public WeatherForecastController(IGetFiveDaysForecastUseCase useCase)
    {
        this.useCase = useCase;
    }

    void IOutputPort.Ok(IEnumerable<WeatherForecast> forecasts)
    {
        this.viewModel = Ok(new GetFiveDaysForecastResponse(forecasts));
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {
        this.useCase.SetOutputPort(this);
        this.useCase.Execute();
        return this.viewModel;
    }
}
