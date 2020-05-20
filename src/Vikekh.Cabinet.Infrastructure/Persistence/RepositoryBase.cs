using Microsoft.EntityFrameworkCore;
using System;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.Infrastructure.Persistence
{
    public abstract class RepositoryBase<T> where T : class, IAggregateRoot
    {
        protected readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected DbSet<T> Set => _context.Set<T>();
    }
}
