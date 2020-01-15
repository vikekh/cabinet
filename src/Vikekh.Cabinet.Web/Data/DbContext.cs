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

        public DbSet<MovieItem> MovieItems { get; set; }

        public DbSet<MovieVersion> MovieVersions { get; set; }
    }
}
