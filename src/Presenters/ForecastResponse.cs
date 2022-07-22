using UseCases.Presenters.Vos;

namespace ApiPresenters;

public record ForecastResponse(
    DateTime Date,
    int TemperatureC,
    int TemperatureF,
    string Summary
) : IPresenterResponse;
