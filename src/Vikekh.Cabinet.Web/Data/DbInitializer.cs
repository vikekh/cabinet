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

            var movieVersions = new List<MovieVersion>();

            foreach (var movie in movies)
            {
                movieVersions.Add(new MovieVersion { Movie = movie });
            }

            movieVersions.Add(new MovieVersion
            {
                Movie = movies.GetMovie("The Good, the Bad and the Ugly", 1966),
                Name = "2004 re-release"
            });

            var dvdMovieFormat = new MovieFormat { Name = "DVD" };
            var blurayMovieFormat = new MovieFormat { Name = "Blu-ray" };

            var movieContainers = new List<MovieContainer>
            {
                new MovieContainer {
                    Name = "The Good, the Bad and the Ugly",
                    MovieDefinitions = new List<MovieDefinition>
                    {
                        new MovieDefinition {
                            MovieVersion = movieVersions.GetMovieVersion("The Good, the Bad and the Ugly", 1966),
                            MovieFormat = dvdMovieFormat
                        }
                    }
                },
                new MovieContainer
                {
                    Name = "The Good, The Bad and The Ugly - 2 Disc Special Edition",
                    MovieDefinitions = new List<MovieDefinition>
                    {
                        new MovieDefinition {
                            MovieVersion = movieVersions.GetMovieVersion("The Good, the Bad and the Ugly", 1966, "2004 re-release"),
                            MovieFormat = dvdMovieFormat
                        }
                    }
                },
                new MovieContainer
                {
                    Name = "The Man With No Name Trilogy",
                    MovieDefinitions = new List<MovieDefinition>
                    {
                        new MovieDefinition {
                            MovieVersion = movieVersions.GetMovieVersion("A Fistful of Dollars", 1964),
                            MovieFormat = blurayMovieFormat
                        },
                        new MovieDefinition {
                            MovieVersion = movieVersions.GetMovieVersion("For a Few Dollars More", 1965),
                            MovieFormat = blurayMovieFormat
                        },
                        new MovieDefinition {
                            MovieVersion = movieVersions.GetMovieVersion("The Good, the Bad and the Ugly", 1966, "2004 re-release"),
                            MovieFormat = blurayMovieFormat
                        }
                    }
                }
            };

            foreach (var movie in movies)
            {
                context.Movies.Add(movie);
            }

            foreach (var version in movieVersions)
            {
                context.MovieVersions.Add(version);
            }

            context.MovieFormats.Add(dvdMovieFormat);
            context.MovieFormats.Add(blurayMovieFormat);

            foreach (var container in movieContainers)
            {
                context.MovieContainers.Add(container);
            }

            context.SaveChanges();
        }

        private static Movie GetMovie(this IEnumerable<Movie> movies, string title, int year)
        {
            return movies.Single(movie => movie.Title == title && movie.Year == year);
        }

        private static MovieContainer GetMovieContainer(this IEnumerable<MovieContainer> containers, string name)
        {
            return containers.Single(container => container.Name == name);
        }

        private static MovieVersion GetMovieVersion(this IEnumerable<MovieVersion> versions, string movieTitle, int movieYear, string name = null)
        {
            return versions.Single(version => version.Movie.Title == movieTitle && version.Movie.Year == movieYear && version.Name == name);
        }
    }
}
