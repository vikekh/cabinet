using System;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieDefinition : EntityBase
    {
        public MovieDefinition() {}

        public MovieDefinition(MovieVersion movieVersion, MovieFormat movieFormat)
        {
            MovieVersion = movieVersion;
            MovieFormat = movieFormat;
        }

        public MovieContainer MovieContainer { get; private set; }

        public MovieFormat MovieFormat { get; private set; }

        public MovieVersion MovieVersion { get; private set; }
    }
}
