using Domain.Dtos;

namespace Domain.Services.Interfaces;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecastDto> GetWeatherForecast();
}