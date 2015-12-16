namespace Pantry.Services.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    public interface IAccountRepository : IDataRepository<Pantry.Data.Models.Account>
    {
    }
}
