using Domain.Dtos;
using Domain.Models;
using Domain.Services.Interfaces;

namespace Domain.Services.Implementations;

public class WeatherForecastService : IWeatherForecastService
{
    private static readonly string[] Summaries =
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecastDto> GetWeatherForecast()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .Select(wf => new WeatherForecastDto(wf.Date, wf.TemperatureC, wf.TemperatureF, wf.Summary))
            .ToArray();
    }
}