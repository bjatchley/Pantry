namespace Pantry.Business.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Practices.Unity;
    using Pantry.Business.Loaders;
    using Repositories;

    public class RepositoryFactory : IRepositoryFactory
    {
        UnityContainer _container;

        public RepositoryFactory()
        {
            UnityContainer container = new UnityContainer();
            UnityLoader.RegisterAll(container);
            _container = container;
        }

        public RepositoryFactory(UnityContainer container)
        {
            _container = container;
        }
        public T GetRepository<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
