using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    [Table("MovieVersion")]
    public class MovieVersion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Movie Movie { get; set; }

        public List<MovieDefinition> MovieDefinitions { get; set; }

        public string Name { get; set; }
    }
}
