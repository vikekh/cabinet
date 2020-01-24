using System.Collections.Generic;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieContainer : EntityBase
    {
        public List<MovieDefinition> MovieDefinitions { get; set; }

        public string Name { get; set; }
    }
}
