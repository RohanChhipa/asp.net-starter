using Domain.Models;

namespace Domain.Repositories;

public interface IWeatherTypeRepository
{
    public Task<IEnumerable<WeatherType>> FetchAll(CancellationToken cancellationToken);
}