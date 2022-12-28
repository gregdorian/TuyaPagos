
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
        
        //public PagedList<T> Find(Expression<Func<T,bool>> predicate, int pageNumber, pageSize);
        
        Task<QueryResult<TEntity>> GetPageAsync(QueryObjectParams queryObjectParams);
 
        Task<QueryResult<TEntity>> GetPageAsync(QueryObjectParams queryObjectParams, 
                                   Expression<Func<TEntity, bool>> predicate);
 
        Task<QueryResult<TEntity>> GetOrderedPageQueryResultAsync
        (QueryObjectParams queryObjectParams, IQueryable<TEntity> query);
        
        void Dispose();
    }
}
