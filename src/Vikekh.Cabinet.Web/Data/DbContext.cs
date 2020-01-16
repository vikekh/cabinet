using Microsoft.EntityFrameworkCore;
using Vikekh.Cabinet.Web.Models;

namespace Vikekh.Cabinet.Web.Data
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
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

            modelBuilder.Entity<MovieDefinition>()
                .HasOne(definition => definition.MovieFormat)
                .WithMany(format => format.MovieDefinitions)
                .HasForeignKey(definition => definition.MovieFormatId);
        }
    }
}
