namespace Pantry.Services.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using Services;
    using Data;
    using Data.Models;
    using Interfaces;
    using Bases;

    public class AccountRepository : DataRepositoryBase<Data.Models.Account, Data.PantryContext>
    {

        protected override Account AddEntity(PantryContext entityContext, Account entity)
        {
            return entityContext.AccountSet.Add(entity);
        }

        protected override Account UpdateEntity(PantryContext entityContext, Account entity)
        {
            return entityContext.AccountSet.Where(p => p.Id == entity.Id).FirstOrDefault();
        }

        protected override IQueryable<Account> GetEntities(PantryContext entityContext)
        {
            return entityContext.AccountSet;
        }

        protected override Account GetEntity(PantryContext entityContext, int id)
        {
            return entityContext.AccountSet.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
