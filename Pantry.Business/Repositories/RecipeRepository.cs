namespace Pantry.Business.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using Data;
    using Common.Base.Classes;
    using Data.Models;

    public class RecipeRepository : DataRepositoryBase<Recipe, PantryContext>, IRecipeRepository, IDisposable
    {
        PantryContext context = new PantryContext();

        protected override Recipe AddEntity(PantryContext entityContext, Recipe entity)
        {
            return entityContext.RecipeSet.Add(entity);
        }

        protected override Recipe UpdateEntity(PantryContext entityContext, Recipe entity)
        {
            return entityContext.RecipeSet.Where(p => p.Id == entity.Id).FirstOrDefault();
        }

        protected override IEnumerable<Recipe> GetEntities(PantryContext entityContext)
        {
            return entityContext.RecipeSet;
        }

        protected override Recipe GetEntity(PantryContext entityContext, int id)
        {
            return entityContext.RecipeSet.Where(p => p.Id == id).FirstOrDefault();
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            context.Dispose();
        }

        #endregion
    }
}
