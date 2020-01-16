using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    [Table("MovieContainer")]
    public class MovieContainer : EntityBase
    {
        public List<MovieDefinition> MovieDefinitions { get; set; }

        public string Name { get; set; }
    }
}
