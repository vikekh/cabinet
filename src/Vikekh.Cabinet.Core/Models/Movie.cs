using System;
using System.Collections.Generic;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Core.Models
{
    public class Movie : EntityBase, IAggregateRoot
    {
        private readonly List<MovieVersion> _movieVersions;

        private Movie()
        {
            _movieVersions = new List<MovieVersion>
            {
                new MovieVersion(null)
            };
        }

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;

            _movieVersions = new List<MovieVersion>
            {
                new MovieVersion(null)
            };
        }

        public IReadOnlyCollection<MovieVersion> MovieVersions => _movieVersions.AsReadOnly();

        public string Title { get; private set; }

        public int Year { get; private set; }

        public void AddMovieVersion(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException();

            _movieVersions.Add(new MovieVersion(name));
        }
    }
}
