
using System.Collections.Generic;

namespace co.Tuya.Domain.Core.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Delete(int id);

        void Modify(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
        
        public PagedList<T> Find(Expression<Func<T,bool>> predicate, int pageNumber, pageSize)

        void Dispose();
    }
}
