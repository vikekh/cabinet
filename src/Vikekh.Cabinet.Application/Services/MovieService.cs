using Vikekh.Cabinet.Application.Dtos;
using Vikekh.Cabinet.Application.Interfaces;
using Vikekh.Cabinet.Core.Interfaces;
using Vikekh.Cabinet.Core.Entities;

namespace Vikekh.Cabinet.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IUnitOfWork _unitOfWork;

        public MovieService(IUnitOfWork unitOfWork, IMovieRepository movieRepository)
        {
            _unitOfWork = unitOfWork;
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieDto movieDto)
        {
            //var movie = movieDto.Map<Movie>() as Movie;
            //_movieRepository.AddMovie(movie);
            //_unitOfWork.Commit();
        }
    }
}
