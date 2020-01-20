using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vikekh.Cabinet.Web.Data;
using Vikekh.Cabinet.Web.Interfaces;
using Vikekh.Cabinet.Web.Models;

namespace Vikekh.Cabinet.Web.Services
{
    public class MovieService
    {
        private readonly DbContext _dbContext;
        private readonly IRepository<Movie> _movieRepository;
        private readonly IRepository<MovieVersion> _movieVersionRepository;

        public MovieService(DbContext dbContext, IRepository<Movie> movieRepository, IRepository<MovieVersion> movieVersionRepository)
        {
            _dbContext = dbContext;
            _movieRepository = movieRepository;
            _movieVersionRepository = movieVersionRepository;
        }

        public void Add(MovieDto movieDto)
        {
            var movie = movieDto.Map<Movie>() as Movie;
            var movieVersion = movieDto.Map<MovieVersion>() as MovieVersion;
            _movieRepository.Create(movie);
            _movieVersionRepository.Create(movieVersion);
            _dbContext.SaveChanges();
        }
    }
}
