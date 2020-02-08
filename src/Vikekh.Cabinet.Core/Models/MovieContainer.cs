using System.Collections.Generic;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieContainer : EntityBase, IAggregateRoot
    {
        private readonly List<MovieDefinition> _movieDefinitions;

        private MovieContainer()
        {
            _movieDefinitions = new List<MovieDefinition>();
        }

        public MovieContainer(string name)
        {
            Name = name;

            _movieDefinitions = new List<MovieDefinition>();
        }

        public IReadOnlyCollection<MovieDefinition> MovieDefinitions => _movieDefinitions.AsReadOnly();

        public string Name { get; private set; }

        public void AddMovieDefinition(MovieVersion movieVersion, MovieFormat movieFormat)
        {
            _movieDefinitions.Add(new MovieDefinition(movieVersion, movieFormat));
        }
    }
}
