
namespace Pantry.Business.Factories
{
    using System;

    public interface IRepositoryFactory
    {
        T GetRepository<T>();
    }
}
