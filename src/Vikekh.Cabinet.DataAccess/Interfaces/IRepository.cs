using System;
using System.Linq;
using Vikekh.Cabinet.Core.Interfaces;

namespace Vikekh.Cabinet.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IQueryable<TEntity> Query { get; }

        void Add(TEntity entity);

        TEntity Get(Guid id);

        void Remove(TEntity entity);

        void Update(TEntity entity);
    }
}
