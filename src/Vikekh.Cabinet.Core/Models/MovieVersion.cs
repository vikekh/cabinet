using System.Collections.Generic;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieVersion : EntityBase
    {
        private readonly List<MovieDefinition> _movieDefinitions;

        private MovieVersion() {}

        public MovieVersion(string name)
        {
            Name = name;
        }

        public Movie Movie { get; private set; }

        public IReadOnlyCollection<MovieDefinition> MovieDefinitions => _movieDefinitions.AsReadOnly();

        public string Name { get; private set; }
    }
}
