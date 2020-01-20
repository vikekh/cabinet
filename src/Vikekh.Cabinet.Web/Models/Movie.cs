using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    [Table("Movie")]
    public class Movie : EntityBase
    {
        public List<MovieVersion> MovieVersions { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
    }
}
