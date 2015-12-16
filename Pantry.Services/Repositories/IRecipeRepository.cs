using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantry.Data.Models;
using Pantry.Services.Interfaces;

namespace Pantry.Services.Repositories
{
    interface IRecipeRepository : IDataRepository<Recipe>
    {

    }
}
