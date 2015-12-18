namespace Pantry.Common.Base.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Utils;

    public abstract class DataRepositoryBase<T, U> : IDisposable, Interfaces.IDataRepository<T>
        where T : class, new()
        where U : DbContext, new()
    {
        U entityContext = new U();

        protected abstract T AddEntity(U entityContext, T entity);

        protected abstract T UpdateEntity(U entityContext, T entity);

        protected abstract IEnumerable<T> GetEntities(U entityContext);

        protected abstract T GetEntity(U entityContext, int id);

        public T Add(T entity)
        {
            T addedEntity = AddEntity(entityContext, entity);
            entityContext.SaveChanges();
            return addedEntity;

        }

        public void Remove(T entity)
        {
           
            entityContext.Entry<T>(entity).State = EntityState.Deleted;
            entityContext.SaveChanges();
           
        }

        public void Remove(int id)
        {
            T entity = GetEntity(entityContext, id);
            entityContext.Entry<T>(entity).State = EntityState.Deleted;
            entityContext.SaveChanges();
        }

        public T Update(T entity)
        {
            T existingEntity = UpdateEntity(entityContext, entity);

            Utils.SimpleMapper.PropertyMap(entity, existingEntity);

            entityContext.SaveChanges();
            return existingEntity;
        }

        public IEnumerable<T> Get()
        {
            return (GetEntities(entityContext));
        }

        public T Get(int id)
        {
            return GetEntity(entityContext, id);
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            entityContext.Dispose();
        }

        #endregion
    }
}
