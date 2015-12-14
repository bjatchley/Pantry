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

    public class AccountRepository
    {
        PantryContext db = new PantryContext();

        public IEnumerable<DataContracts.Account> GetAccounts()
        {
            return from p in db.AccountSet
                   select new DataContracts.Account
                   {
                       Email = p.Email,
                       FirstName = p.FirstName,
                       LastName = p.LastName,
                       Id = p.Id
                   };
        }
    }
}
