using co.Tuya.Domain.Core.Repositories;
using co.Tuya.Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Tuya.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {

            try
            {
                using (var context = new TuyaContext())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede guardar el registro", ex);
            }
        }


        public void Delete(int id)
        {
            try
            {
                using (var context = new TuyaContext())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar el registro", ex);
            }
        }

        public void Dispose()
        {
           // this.Dispose;
            //throw new NotImplementedException();
        }


        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new TuyaContext())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registros", ex);
            }
        }


        public TEntity GetById(int id)
        {
            try
            {
                using (var context = new TuyaContext())
                {
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo recuperar el registro", ex);
            }
        }


        public void Modify(TEntity entity)
        {

            try
            {
                using (var context = new TuyaContext())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede actualizar el registro", ex);
            }
        }
        
        public async Task<QueryResult<TEntity>> 
        GetOrderedPageQueryResultAsync
        (QueryObjectParams queryObjectParams, IQueryable<TEntity> query)
        {
            IQueryable<TEntity> OrderedQuery = query;
 
            if (queryObjectParams.SortingParams != null && 
                queryObjectParams.SortingParams.Count > 0)
            {
                OrderedQuery = SortingExtension.GetOrdering
                               (query, queryObjectParams.SortingParams);
            }
 
            var totalCount = await query.CountAsync().ConfigureAwait(false);
 
            if (OrderedQuery != null)
            {
                var fecthedItems = 
                await GetPagePrivateQuery
                (OrderedQuery, queryObjectParams).ToListAsync().ConfigureAwait(false);
 
                return new QueryResult<TEntity>(fecthedItems, totalCount);
            }
 
            return new QueryResult<TEntity>(await GetPagePrivateQuery
            (_dbSet, queryObjectParams).ToListAsync().ConfigureAwait(false), totalCount);
        } 
 
        private IQueryable<TEntity> GetPagePrivateQuery
        (IQueryable<TEntity> query, QueryObjectParams queryObjectParams)
        {
            return query.Skip((queryObjectParams.PageNumber - 1) * 
            queryObjectParams.PageSize).Take(queryObjectParams.PageSize);
        }
    }
}
