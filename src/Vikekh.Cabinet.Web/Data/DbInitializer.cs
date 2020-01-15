using System.Collections.Generic;
using System.Linq;
using Vikekh.Cabinet.Web.Models;

namespace Vikekh.Cabinet.Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Movies.Any()) return;

            var movies = new List<Movie>
            {
                new Movie { Title = "A Fistful of Dollars", Year = 1964 },
                new Movie { Title = "For a Few Dollars More", Year = 1965 },
                new Movie { Title = "The Good, the Bad and the Ugly", Year = 1966 }
            };

            foreach (var movie in movies)
            {
                context.Movies.Add(movie);
                context.MovieVersions.Add(new MovieVersion { Movie = movie });
            }

            context.SaveChanges();

            // Movie versions
            context.MovieVersions.Add(new MovieVersion
            {
                Movie = context.GetMovie("The Good, the Bad and the Ugly", 1966),
                Name = "2004 re-release"
            });
            context.SaveChanges();

            // Movie items
            context.MovieItems.Add(new MovieItem
            {
                MovieVersion = context.GetMovieVersion("A Fistful of Dollars", 1964),
                Name = "Blu-ray"
            });
            context.MovieItems.Add(new MovieItem
            {
                MovieVersion = context.GetMovieVersion("For a Few Dollars More", 1965),
                Name = "Blu-ray"
            });
            context.MovieItems.Add(new MovieItem
            {
                MovieVersion = context.GetMovieVersion("The Good, the Bad and the Ugly", 1966),
                Name = "DVD"
            });
            context.MovieItems.Add(new MovieItem
            {
                MovieVersion = context.GetMovieVersion("The Good, the Bad and the Ugly", 1966, "2004 re-release"),
                Name = "DVD"
            });
            context.MovieItems.Add(new MovieItem
            {
                MovieVersion = context.GetMovieVersion("The Good, the Bad and the Ugly", 1966, "2004 re-release"),
                Name = "Blu-ray"
            });
            context.SaveChanges();

            // Movie containers
            context.MovieContainers.Add(new MovieContainer {
                Name = "The Good, the Bad and the Ugly",
                MovieItems = new List<MovieItem> { context.GetMovieItem("The Good, the Bad and the Ugly", 1966, "DVD") }
            });
            context.MovieContainers.Add(new MovieContainer
            {
                Name = "The Good, The Bad and The Ugly - 2 Disc Special Edition",
                MovieItems = new List<MovieItem> { context.GetMovieItem("The Good, the Bad and the Ugly", 1966, "DVD", "2004 re-release") }
            });
            context.MovieContainers.Add(new MovieContainer
            {
                Name = "The Man With No Name Trilogy",
                MovieItems = new List<MovieItem> {
                    context.GetMovieItem("A Fistful of Dollars", 1964, "Blu-ray"),
                    context.GetMovieItem("For a Few Dollars More", 1965, "Blu-ray"),
                    context.GetMovieItem("The Good, the Bad and the Ugly", 1966, "Blu-ray", "2004 re-release")
                }
            });
            context.SaveChanges();
        }

        private static Movie GetMovie(this DbContext context, string title, int year)
        {
            return context.Movies.Single(movie => movie.Title == title && movie.Year == year);
        }

        private static MovieVersion GetMovieVersion(this DbContext context, string movieTitle, int movieYear, string name = null)
        {
            var movie = context.GetMovie(movieTitle, movieYear);
            return context.MovieVersions.Single(version => version.Movie == movie && version.Name == name);
        }

        private static MovieItem GetMovieItem(this DbContext context, string movieTitle, int movieYear, string name, string versionName = null)
        {
            var version = context.GetMovieVersion(movieTitle, movieYear, versionName);
            return context.MovieItems.Single(item => item.MovieVersion == version && item.Name == name);
        }
    }
}
