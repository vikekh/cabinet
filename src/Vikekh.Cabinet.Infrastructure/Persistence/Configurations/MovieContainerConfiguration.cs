using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vikekh.Cabinet.Core.Entities;

namespace Vikekh.Cabinet.Infrastructure.Persistence.Configurations
{
    public class MovieContainerConfiguration : IEntityTypeConfiguration<MovieContainer>
    {
        public void Configure(EntityTypeBuilder<MovieContainer> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(property => property.Id);

            builder.HasMany(m => m.MovieDefinitions)
                .WithOne();
        }
    }
}
