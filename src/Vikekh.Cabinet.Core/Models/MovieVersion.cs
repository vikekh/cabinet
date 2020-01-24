using System.Collections.Generic;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieVersion : EntityBase
    {
        public Movie Movie { get; set; }

        public List<MovieDefinition> MovieDefinitions { get; set; }

        public string Name { get; set; }
    }
}
