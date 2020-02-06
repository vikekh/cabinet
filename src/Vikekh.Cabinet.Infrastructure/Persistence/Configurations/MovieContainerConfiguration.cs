using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vikekh.Cabinet.Core.Models;

namespace Vikekh.Cabinet.Infrastructure.Persistence.Configurations
{
    public class MovieContainerConfiguration : IEntityTypeConfiguration<MovieContainer>
    {
        public void Configure(EntityTypeBuilder<MovieContainer> builder)
        {
            builder.Property(property => property.Id).ValueGeneratedOnAdd();
        }
    }
}
