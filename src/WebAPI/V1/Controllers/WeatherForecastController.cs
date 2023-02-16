using Domain.Dtos;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.V1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecastDto> Get()
    {
        return _weatherForecastService.GetWeatherForecast();
    }
}