using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    [Table("MovieFormat")]
    public class MovieFormat : EntityBase
    {
        public List<MovieDefinition> MovieDefinitions { get; set; }

        public string Name { get; set; }
    }
}
