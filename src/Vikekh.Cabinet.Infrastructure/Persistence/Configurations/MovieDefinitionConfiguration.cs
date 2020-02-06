using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vikekh.Cabinet.Core.Models;

namespace Vikekh.Cabinet.Infrastructure.Persistence.Configurations
{
    public class MovieDefinitionConfiguration : IEntityTypeConfiguration<MovieDefinition>
    {
        public void Configure(EntityTypeBuilder<MovieDefinition> builder)
        {
            builder.Property(property => property.Id).ValueGeneratedOnAdd();

            builder.HasOne(m => m.MovieContainer)
                .WithMany(m => m.MovieDefinitions);

            builder.HasOne(m => m.MovieFormat)
                .WithMany();

            builder.HasOne(m => m.MovieVersion)
                .WithMany(m => m.MovieDefinitions);
        }
    }
}
