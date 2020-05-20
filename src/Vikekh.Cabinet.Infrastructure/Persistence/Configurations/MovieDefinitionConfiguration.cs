using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vikekh.Cabinet.Core.Entities;

namespace Vikekh.Cabinet.Infrastructure.Persistence.Configurations
{
    public class MovieDefinitionConfiguration : IEntityTypeConfiguration<MovieDefinition>
    {
        public void Configure(EntityTypeBuilder<MovieDefinition> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(property => property.Id);

            builder.HasOne(m => m.MovieVersion)
                .WithMany();
        }
    }
}
