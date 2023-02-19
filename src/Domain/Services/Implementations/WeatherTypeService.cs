using Domain.Dtos;
using Domain.Models;
using Domain.Repositories;
using Domain.Services.Interfaces;

namespace Domain.Services.Implementations;

public class WeatherTypeService : IWeatherTypeService
{
    private readonly IWeatherTypeRepository _weatherTypeRepository;

    public WeatherTypeService(IWeatherTypeRepository weatherTypeRepository)
    {
        _weatherTypeRepository = weatherTypeRepository;
    }
    
    public async Task<IEnumerable<WeatherTypeDto>> GetWeatherTypesAsync(CancellationToken cancellationToken)
    {
        var types = await _weatherTypeRepository.FetchAll(cancellationToken);
        return types.Select(type => new WeatherTypeDto(type.Id, type.Description));
    }
}