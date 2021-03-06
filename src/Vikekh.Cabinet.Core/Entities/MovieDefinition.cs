using Vikekh.Cabinet.Core.Common;
using Vikekh.Cabinet.Core.Enums;

namespace Vikekh.Cabinet.Core.Entities
{
    public class MovieDefinition : EntityBase
    {
        private MovieDefinition() {}

        public MovieDefinition(MovieVersion movieVersion, MovieFormat movieFormat)
        {
            MovieVersion = movieVersion;
            MovieFormat = movieFormat;
        }

        public MovieFormat MovieFormat { get; private set; }

        public MovieVersion MovieVersion { get; private set; }
    }
}
