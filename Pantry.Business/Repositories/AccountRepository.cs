namespace Pantry.Business.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using Data;
    using Data.Models;
    using Common.Base.Interfaces;
    using Common.Base.Classes;

    public class AccountRepository : DataRepositoryBase<Data.Models.Account, Data.PantryContext>, IAccountRepository, IDisposable
    {
        PantryContext context = new PantryContext();

        protected override Account AddEntity(PantryContext entityContext, Account entity)
        {
            return entityContext.AccountSet.Add(entity);
        }

        protected override Account UpdateEntity(PantryContext entityContext, Account entity)
        {
            return entityContext.AccountSet.Where(p => p.Id == entity.Id).FirstOrDefault();
        }

        protected override IEnumerable<Account> GetEntities(PantryContext entityContext)
        {
            return entityContext.AccountSet;
        }

        protected override Account GetEntity(PantryContext entityContext, int id)
        {
            return entityContext.AccountSet.Where(p => p.Id == id).FirstOrDefault();
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            context.Dispose();
        }

        #endregion
    }
}
