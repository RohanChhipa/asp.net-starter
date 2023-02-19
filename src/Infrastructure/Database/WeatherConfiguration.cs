using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database;

public class WeatherTypeConfiguration : IEntityTypeConfiguration<WeatherType>
{
    public void Configure(EntityTypeBuilder<WeatherType> builder)
    {
        builder
            .HasKey(type => type.Id);

        builder
            .Property(type => type.Description)
            .IsRequired()
            .HasMaxLength(100);
    }
}