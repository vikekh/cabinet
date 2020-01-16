using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    [Table("Movie")]
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public List<MovieVersion> MovieVersions { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
    }
}
