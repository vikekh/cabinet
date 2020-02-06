using System;
using System.Collections.Generic;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieContainer : EntityBase
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
            _movieDefinitions.Add(new MovieDefinition(this, movieVersion, movieFormat));
        }
    }
}
