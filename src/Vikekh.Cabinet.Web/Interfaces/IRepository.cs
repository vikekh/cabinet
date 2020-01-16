using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikekh.Cabinet.Web.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        T Create(T entity);

        T Delete(int id);

        T Get(Guid id);

        IEnumerable<T> GetAll();
        
        T Update(T entity);
    }
}
