using System;
using System.Collections.Generic;
using Vikekh.Cabinet.Core.Common;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Entities
{
    public class Movie : EntityBase, IAggregateRoot
    {
        private readonly List<MovieVersion> _movieVersions = new List<MovieVersion>();

        private Movie() : base()
        {
            AddMovieVersion(null);
        }

        public Movie(string name, int yearReleased) : this()
        {
            Name = name;
            YearReleased = yearReleased;
        }

        public IReadOnlyCollection<MovieVersion> MovieVersions => _movieVersions.AsReadOnly();

        public string Name { get; private set; }

        public int YearReleased { get; private set; }

        public void AddMovieVersion(MovieVersion movieVersion)
        {
            if (_movieVersions.Exists(m => m.Name == movieVersion.Name)) throw new Exception("Duplicate");

            _movieVersions.Add(movieVersion);
        }

        public MovieVersion GetMovieVersion(Guid id)
        {
            return _movieVersions.Find(m => m.Id == id);
        }

        public MovieVersion GetMovieVersion(string name = null)
        {
            return _movieVersions.Find(m => m.Name == name);
        }
    }
}
