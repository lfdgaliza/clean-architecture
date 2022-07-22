﻿using Entities;
using UseCases.Data;

namespace InMemoryPersistence;
public class ForecastFetcher : IForecastFetcher
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecast> GetForecastByNumberOfDays(int numberOfDays)
    {
        return Enumerable.Range(1, numberOfDays).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });
    }
}
