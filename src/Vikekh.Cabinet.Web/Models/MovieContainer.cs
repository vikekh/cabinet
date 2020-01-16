using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    [Table("MovieContainer")]
    public class MovieContainer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public List<MovieDefinition> MovieDefinitions { get; set; }

        public string Name { get; set; }
    }
}
