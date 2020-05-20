using Vikekh.Cabinet.Core.Common;

namespace Vikekh.Cabinet.Core.Entities
{
    public class MovieVersion : EntityBase
    {
        private MovieVersion() : base() { }

        public MovieVersion(string name) : this()
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
