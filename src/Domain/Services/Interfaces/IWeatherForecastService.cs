using Domain.Dtos;

namespace Domain.Services.Interfaces;

public interface IWeatherForecastService
{
    Task<IEnumerable<WeatherForecastDto>> GetWeatherForecastAsync(CancellationToken cancellationToken);
}