using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vikekh.Cabinet.Core.Entities;

namespace Vikekh.Cabinet.Infrastructure.Persistence.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(property => property.Id).ValueGeneratedOnAdd();

            builder.HasMany(m => m.MovieVersions)
                .WithOne();
        }
    }
}
