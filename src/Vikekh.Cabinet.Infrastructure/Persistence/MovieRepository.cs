using System;
using Vikekh.Cabinet.Core.Entities;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Infrastructure.Persistence
{
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context) {}

        public void AddMovie(Movie movie)
        {
            _context.Set<Movie>().Add(movie);
            //Set.Add(movie);
        }

        public Movie GetMovie(Guid movieId)
        {
            var movie = Set.Find(movieId);

            if (movie == null) throw new Exception();

            return movie;
        }
    }
}
