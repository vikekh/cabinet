using System.Collections.Generic;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieFormat : EntityBase
    {
        public List<MovieDefinition> MovieDefinitions { get; set; }

        public string Name { get; set; }
    }
}
