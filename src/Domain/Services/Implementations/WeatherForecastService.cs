using Domain.Dtos;
using Domain.Models;
using Domain.Repositories;
using Domain.Services.Interfaces;

namespace Domain.Services.Implementations;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherTypeRepository _weatherTypeRepository;

    public WeatherForecastService(IWeatherTypeRepository weatherTypeRepository)
    {
        _weatherTypeRepository = weatherTypeRepository;
    }
    
    public async Task<IEnumerable<WeatherForecastDto>> GetWeatherForecastAsync(CancellationToken cancellationToken)
    {
        var summaries = (await _weatherTypeRepository.FetchAll(cancellationToken))
            .Select(type => type.Description)
            .ToList();
        
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Count)]
            })
            .Select(wf => new WeatherForecastDto(wf.Date, wf.TemperatureC, wf.TemperatureF, wf.Summary))
            .ToArray();
    }
}