using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikekh.Cabinet.Web.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        //void Delete(TEntity id);

        //TEntity Get(Guid id);

        //IQueryable<TEntity> GetAll();

        //void Update(TEntity entity);
    }
}
