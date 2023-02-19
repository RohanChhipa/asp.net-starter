using Domain.Dtos;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.V1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherTypeController : ControllerBase
{
    private readonly IWeatherTypeService _weatherTypeService;

    public WeatherTypeController(IWeatherTypeService weatherTypeService)
    {
        _weatherTypeService = weatherTypeService;
    }
    
    [HttpGet]
    public Task<IEnumerable<WeatherTypeDto>> Get(CancellationToken cancellationToken)
    {
        return _weatherTypeService.GetWeatherTypesAsync(cancellationToken);
    }
}