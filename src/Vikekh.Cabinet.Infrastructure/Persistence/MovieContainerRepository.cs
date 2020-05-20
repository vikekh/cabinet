using Microsoft.EntityFrameworkCore;
using System;
using Vikekh.Cabinet.Core.Entities;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Infrastructure.Persistence
{
    public class MovieContainerRepository : RepositoryBase<MovieContainer>
    {
        public MovieContainerRepository(ApplicationDbContext context) : base(context) {}

        public void AddMovieContainer(MovieContainer movieContainer)
        {
            Set.Add(movieContainer);
        }
    }
}
