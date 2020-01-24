using Microsoft.EntityFrameworkCore;
using Vikekh.Cabinet.Core.Interfaces;
using Vikekh.Cabinet.Core.Models;

namespace Vikekh.Cabinet.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieContainer> MovieContainers { get; set; }

        public DbSet<MovieDefinition> MovieDefinitions { get; set; }

        public DbSet<MovieFormat> MovieFormats { get; set; }

        public DbSet<MovieVersion> MovieVersions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IEntity>()
                .Property(property => property.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<MovieDefinition>()
                .HasKey(definition => new { definition.MovieContainerId, definition.MovieVersionId, definition.MovieFormatId });

            modelBuilder.Entity<MovieDefinition>()
                .HasOne(definition => definition.MovieContainer)
                .WithMany(container => container.MovieDefinitions)
                .HasForeignKey(definition => definition.MovieContainerId);

            modelBuilder.Entity<MovieDefinition>()
                .HasOne(definition => definition.MovieVersion)
                .WithMany(version => version.MovieDefinitions)
                .HasForeignKey(definition => definition.MovieVersionId);
        }
    }
}
