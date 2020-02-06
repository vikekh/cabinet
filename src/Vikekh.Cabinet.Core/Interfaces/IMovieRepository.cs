using System;
using System.Collections.Generic;
using System.Text;
using Vikekh.Cabinet.Core.Models;

namespace Vikekh.Cabinet.Core.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);

        Movie GetMovie(Guid movieId);
    }
}
