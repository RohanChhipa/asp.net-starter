using Domain.Dtos;

namespace Domain.Services.Interfaces;

public interface IWeatherTypeService
{
    Task<IEnumerable<WeatherTypeDto>> GetWeatherTypesAsync(CancellationToken cancellationToken);
}