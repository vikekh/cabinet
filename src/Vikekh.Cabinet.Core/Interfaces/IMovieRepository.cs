using System;
using Vikekh.Cabinet.Core.Entities;

namespace Vikekh.Cabinet.Core.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);

        Movie GetMovie(Guid movieId);
    }
}
