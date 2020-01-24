using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vikekh.Cabinet.Core.Interfaces;
using Vikekh.Cabinet.DataAccess.Interfaces;

namespace Vikekh.Cabinet.DataAccess
{
    public /*sealed*/ class Repository<TDbContext, TEntity> : IRepository<TEntity>
        where TDbContext : ApplicationDbContext
        where TEntity : IEntity
    {
        protected /*private*/ TDbContext Context { get; private set; }

        protected /*private*/ DbSet<TEntity> Set => Context.Set<TEntity>();

        public Repository(TDbContext dbContext)
        {
            Context = dbContext;
        }

        public IQueryable<TEntity> Query => Set;

        public TEntity Find(params object[] keys)
        {
            return Set.Find(keys);
        }

        public void Insert(TEntity entity)
        {
            var entry = Context.Entry(entity);
            if (entry.State == EntityState.Detached)
                Set.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            var entry = Context.Entry(entity);
            if (entry.State == EntityState.Detached)
                Set.Attach(entity);
            Set.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            var entry = Context.Entry(entity);
            if (entry.State == EntityState.Detached)
                Set.Attach(entity);
            entry.State = EntityState.Modified;
        }
    }
}
