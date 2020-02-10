using System;
using System.Collections.Generic;
using Vikekh.Cabinet.Core.Common;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Entities
{
    public class Movie : EntityBase, IAggregateRoot
    {
        private readonly List<MovieVersion> _movieVersions = new List<MovieVersion>();

        private Movie()
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

        public void AddMovieVersion(string name)
        {
            if (_movieVersions.Exists(m => m.Name == name)) throw new ArgumentException("Duplicate", nameof(name));

            _movieVersions.Add(new MovieVersion(name));
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
