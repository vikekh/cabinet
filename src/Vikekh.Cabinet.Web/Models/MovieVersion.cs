using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    public class MovieVersion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Movie Movie { get; set; }

        public List<MovieItem> MovieItems { get; set; }

        public string Name { get; set; }
    }
}
