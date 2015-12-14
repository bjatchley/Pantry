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

    public class RecipeRepository
    {
        PantryContext db = new PantryContext();

        public IEnumerable<DataContracts.Recipe> GetRecipes()
        {
            return from p in db.RecipeSet
                   select new DataContracts.Recipe
                   {
                       Name = p.Name,
                       Id = p.Id
                   };
        }
    }
}
