using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vikekh.Cabinet.Web.Models
{
    public class MovieItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public MovieVersion MovieVersion { get; set; }

        public string Name { get; set; }
    }
}
