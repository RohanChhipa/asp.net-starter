using Domain.Models;
using Domain.Repositories;
using Domain.Services.Implementations;
using Domain.Services.Interfaces;
using Infrastructure.Database;
using Infrastructure.Reqres;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, ReqresUserRepository>();
builder.Services.AddScoped<IWeatherTypeRepository, WeatherTypeRepository>();
builder.Services.AddScoped<IWeatherTypeService, WeatherTypeService>();
builder.Services.AddDbContext<StarterContext>(
    optionsBuilder => optionsBuilder.UseInMemoryDatabase("StarterDB")
);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// This can be removed when moving away from an in-memory DB
// Ideally this data should be seeded using an actual DB migrator
// THIS IS JUST FOR DEMO PURPOSES
Seed();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void Seed()
{
    using var scope = app.Services.CreateScope();
    var starterContext = scope.ServiceProvider.GetService<StarterContext>()!;
    starterContext.WeatherTypes.AddRange(
        new WeatherType { Id = Guid.NewGuid(), Description = "Freezing" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Bracing" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Chilly" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Cool" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Mild" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Warm" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Balmy" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Hot" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Sweltering" },
        new WeatherType { Id = Guid.NewGuid(), Description = "Scorching" }
    );
    starterContext.SaveChanges();
}