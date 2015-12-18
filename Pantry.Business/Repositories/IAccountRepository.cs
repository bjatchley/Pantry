namespace Pantry.Business.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data.Models;
    using Common.Base.Interfaces;

    public interface IAccountRepository : IDataRepository<Account>, IDisposable
    {

    }
}
