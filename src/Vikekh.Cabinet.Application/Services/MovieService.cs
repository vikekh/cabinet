using Vikekh.Cabinet.Application.Dtos;
using Vikekh.Cabinet.Application.Interfaces;
using Vikekh.Cabinet.Core.Models;
using Vikekh.Cabinet.DataAccess;

namespace Vikekh.Cabinet.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _dbContext;

        public MovieService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddMovie(MovieDto movieDto)
        {
            var movie = movieDto.Map<Movie>() as Movie;
            var movieVersion = movieDto.Map<MovieVersion>() as MovieVersion;
            _dbContext.Movies.Add(movie);
            _dbContext.MovieVersions.Add(movieVersion);
            _dbContext.SaveChanges();
        }
    }
}
