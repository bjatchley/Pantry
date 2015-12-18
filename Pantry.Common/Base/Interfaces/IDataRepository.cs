namespace Pantry.Common.Base.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IDataRepository : IDisposable
    {
    }

    public interface IDataRepository<T> : IDisposable, IDataRepository
        where T : class, new()
    {
        T Add(T entity);

        void Remove(T entity);

        void Remove(int id);

        T Update(T Entity);

        IEnumerable<T> Get();

        T Get(int id);
    }
}
