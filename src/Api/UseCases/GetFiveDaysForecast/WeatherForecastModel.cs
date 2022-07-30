using Entities;
using System.ComponentModel.DataAnnotations;

namespace Api.UseCases.GetFiveDaysForecast;

public sealed record WeatherForecastModel(
    [Required] string Date,
    [Required] string TemperatureC,
    [Required] string TemperatureF,
    string? Summary)
{
    public WeatherForecastModel(WeatherForecast weatherForecast)
        : this(
             weatherForecast.Date.ToShortDateString(),
             weatherForecast.TemperatureC.ToString(),
             weatherForecast.TemperatureF.ToString(),
             weatherForecast.Summary)
    { }
}