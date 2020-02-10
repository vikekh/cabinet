using System.Collections.Generic;
using Vikekh.Cabinet.Core.Common;
using Vikekh.Cabinet.Core.Enums;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Entities
{
    public class MovieContainer : EntityBase, IAggregateRoot
    {
        private readonly List<MovieDefinition> _movieDefinitions = new List<MovieDefinition>();

        private MovieContainer() {}

        public MovieContainer(string name)
        {
            Name = name;
        }

        public IReadOnlyCollection<MovieDefinition> MovieDefinitions => _movieDefinitions.AsReadOnly();

        public string Name { get; private set; }

        public void AddMovieDefinition(MovieDefinition movieDefinition)
        {
            _movieDefinitions.Add(movieDefinition);
        }
    }
}
