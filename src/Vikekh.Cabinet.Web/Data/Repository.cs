using Microsoft.EntityFrameworkCore;
using Vikekh.Cabinet.Web.Interfaces;
using DbContext = Vikekh.Cabinet.Web.Data.DbContext;

namespace Vikekh.Cabinet.Web.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }
    }
}
