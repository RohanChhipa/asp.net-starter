using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class WeatherTypeRepository : IWeatherTypeRepository
{
    private readonly StarterContext _starterContext;

    public WeatherTypeRepository(StarterContext starterContext)
    {
        _starterContext = starterContext;
    }
    
    public async Task<IEnumerable<WeatherType>> FetchAll(CancellationToken cancellationToken)
    {
        return await _starterContext.WeatherTypes.ToListAsync(cancellationToken);
    }
}