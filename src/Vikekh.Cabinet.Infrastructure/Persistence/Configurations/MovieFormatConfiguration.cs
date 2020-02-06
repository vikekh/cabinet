using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vikekh.Cabinet.Core.Models;

namespace Vikekh.Cabinet.Infrastructure.Persistence.Configurations
{
    public class MovieFormatConfiguration : IEntityTypeConfiguration<MovieFormat>
    {
        public void Configure(EntityTypeBuilder<MovieFormat> builder)
        {
            builder.Property(property => property.Id).ValueGeneratedOnAdd();
        }
    }
}
