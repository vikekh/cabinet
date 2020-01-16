using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    [Table("MovieDefinition")]
    public class MovieDefinition
    {
        public MovieContainer MovieContainer { get; set; }

        public Guid MovieContainerId { get; set; }

        public MovieFormat MovieFormat { get; set; }

        public Guid MovieFormatId { get; set; }

        public MovieVersion MovieVersion { get; set; }

        public Guid MovieVersionId { get; set; }
    }
}
