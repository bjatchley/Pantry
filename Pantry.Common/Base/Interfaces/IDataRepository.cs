namespace Pantry.Common.Base.Interfaces
{
    using System.Linq;

    public interface IDataRepository
    {
    }

    public interface IDataRepository<T> : IDataRepository
        where T : class, new()
    {
        T Add(T entity);

        void Remove(T entity);

        void Remove(int id);

        T Update(T Entity);

        IQueryable<T> Get();

        T Get(int id);
    }
}
