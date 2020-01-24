using System;

namespace Vikekh.Cabinet.Core.Models
{
    public class MovieDefinition : EntityBase
    {
        public MovieContainer MovieContainer { get; set; }

        public Guid MovieContainerId { get; set; }

        public MovieFormat MovieFormat { get; set; }

        public Guid MovieFormatId { get; set; }

        public MovieVersion MovieVersion { get; set; }

        public Guid MovieVersionId { get; set; }
    }
}
