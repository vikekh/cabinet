using System;
using Vikekh.Cabinet.Core.Entities;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Infrastructure.Persistence
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
        }

        public Movie GetMovie(Guid movieId)
        {
            var movie = _context.Movies.Find(movieId);

            if (movie == null) throw new Exception();

            return movie;
        }
    }
}
