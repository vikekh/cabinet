using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vikekh.Cabinet.Core.Models;

namespace Vikekh.Cabinet.Infrastructure.Persistence.Configurations
{
    public class MovieVersionConfiguration : IEntityTypeConfiguration<MovieVersion>
    {
        public void Configure(EntityTypeBuilder<MovieVersion> builder)
        {
            builder.Property(property => property.Id).ValueGeneratedOnAdd();

            builder.HasOne(n => n.Movie)
                .WithMany(n => n.MovieVersions);
        }
    }
}
