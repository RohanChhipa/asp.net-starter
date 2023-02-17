namespace Domain.Dtos;

public record WeatherForecastDto
(
    DateTime Date,
    int TemperatureC,
    int TemperatureF,
    string? Summary
);