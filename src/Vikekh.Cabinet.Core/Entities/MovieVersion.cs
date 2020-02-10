using Vikekh.Cabinet.Core.Common;

namespace Vikekh.Cabinet.Core.Entities
{
    public class MovieVersion : EntityBase
    {
        private MovieVersion() {}

        public MovieVersion(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
