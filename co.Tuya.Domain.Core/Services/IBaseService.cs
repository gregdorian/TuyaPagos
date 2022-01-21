using System.Collections.Generic;


namespace co.Tuya.Domain.Core.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Delete(int id);

        void Modify(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Dispose();
    }
}
