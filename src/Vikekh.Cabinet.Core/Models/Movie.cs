using System.Collections.Generic;

namespace Vikekh.Cabinet.Core.Models
{
    public class Movie : EntityBase
    {
        public List<MovieVersion> MovieVersions { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
    }
}
