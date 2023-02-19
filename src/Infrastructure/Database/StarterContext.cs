using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class StarterContext : DbContext
{
    public DbSet<WeatherType> WeatherTypes { get; set; }
    
    public StarterContext(DbContextOptions<StarterContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new WeatherTypeConfiguration());
    }
}