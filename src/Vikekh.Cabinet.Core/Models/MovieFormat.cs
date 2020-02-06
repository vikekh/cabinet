using System.Collections.Generic;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieFormat : EntityBase
    {
        private MovieFormat() {}

        public MovieFormat(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
